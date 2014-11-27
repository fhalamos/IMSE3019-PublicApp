/*=======================================================================================================================
    Parking System Project - IMSE3019 - Public Application

    Created by  : Felipe Alamos
    Date        : 2nd December 2014
    Remark      :                   
        1. The project is based in the project developed by Bill Chan, imseWCard2, for IMSE3019 Smart Card Laboratory.

        2. The reference imseWSC1K should be added.

        3. The current application enables a Public Center to administrate the parking card.

        4. The 1st block of Sector 14 is used to save the card id. THe 2nd block of Sector 14 is used to save the car patent.
           The 3rd block of Sector 14 is used to save the entrance time. 
        
        5. The 3 blocks of Sector 15 are used to save the amounts of the 3 biggest purchases, i.e. blocks 0x3C, 0x3D, 0x3E
*/
//=======================================================================================================================


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using imseWSC1K;  // the class library for contactless smart card

namespace imseWCard2
{
    public partial class Main : Form
    {
        // create an object to handle the card
        private wSCard CADw = new wSCard();

        // true if a smart card is connected. Otherwise, false. 
        private bool connected = false;

        // true if a transaction is done. Reset to false if a connection is lost.
        private bool transectionDone = false;

        // Block 0, 1 and 2 of sector 15, i.e. block 0x3Cx, 0x3D, 0x3E, are used to save the biggest purchases
        private int amountsSector = 15;
        private int amount0Block = 0x3C;
        private int amount1Block = 0x3D;
        private int amount2Block = 0x3E;

        //Block 0 of sector 14, i.e block 0x38, is used to save card ID. Block 1, i.e block 0x39, is used to save car patent.
        //Block 2, i.e. block 0x3A is used to save the time of entrance

        private int informationSector = 14;
        private int cardIdBlock = 0x38;
        private int carPatentBlock = 0x39;
        private int entranceTimeBlock = 0x3A;

        //Parking fees
        private int pricePerHour = 30;

        //Free hour policy. 400 Dollars = 5 free hours (Combo1). 200 Dollares = 2 free hours (Combo2). No accumulative. Money in cents
        private int combo1freeHours = 5;
        private int combo1MoneyNeeded = 40000;
        private int combo2freeHours = 2;
        private int combo2MoneyNeeded = 20000;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!CADw.initialize())  // initialize the object CADw
            {
                textBoxMsg.Text = "Reader initialization failed!";
                return;
            }
            textBoxMsg.Text = "Place your card in reader to read card";
            timer1.Enabled = true;
            timer2.Enabled = false;
            timer3.Enabled = false;

            unDisplayInformation();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!CADw.connect())
            {
                announceDisconection();
            }
            else
            {
                if (!connected)
                {
                    announceConnection();
                }

                displayStaticLabels();


                // Authenticate before reading or writing to a sector
                if (authenticateSector(amountsSector))
                {
                    
                    long amount = displayAmountOfParkingCredit();

                    //Display amout of free parking hours available
                    quantityFreeHourslabel.Text = calculateFreeParkingHours(amount);
                }

                if (authenticateSector(informationSector))
                {
                    displayCardInformation();
                    displayEntranceAndActualTime();

                    calculatAndDisplayParkingDebt(Int32.Parse(quantityFreeHourslabel.Text));
                }
            }
        }

        private void displayStaticLabels()
        {
            cardInformationStaticLabel.Visible = true;
            cardIdStaticLabel.Visible = true;
            carPatentStaticLabel.Visible = true;
            entranceTimeStaticLabel.Visible = true;
            freeHoursStaticLabel.Visible = true;
            parkingCreditStaticLabel.Visible = true;
            actualTimeStaticLabel.Visible = true;
            actualParkingDebtStaticLabel.Visible = true;
        }

        private void calculatAndDisplayParkingDebt(int freeHours)
        {
            //Get actual time
            System.DateTime actualTime = System.DateTime.Now;
            
            //Get entrance time
            System.DateTime entranceTime = getEntranceTime();
            
            //Calculate debt
            double hoursDifference = Math.Ceiling(actualTime.Subtract(entranceTime).TotalHours);
            double hoursToPay = hoursDifference - freeHours;

            if (hoursToPay < 0)
                hoursToPay = 0;

            double debtToPay = hoursToPay * pricePerHour;

            string hourOrHours = "hour";
            if (hoursToPay != 1)
                hourOrHours = "hours";

            actualParkingDebtLabel.Text = "$"+debtToPay + " ("+hoursToPay+" "+hourOrHours+")";
        }

        private DateTime getEntranceTime()
        {

            string entranceTime_ = "";
            if (CADw.read(entranceTimeBlock, ref entranceTime_) == false)
            {
                textBoxMsg.Text = "Read value error!";
                //return;

            }
            if (entranceTime_ != "") //sometimes the reader wont read, cause we just took out the card
            {
                string[] entranceTimeSplited = entranceTime_.Split('_');
                string[] dateEntranceTime = entranceTimeSplited[0].Split('-');
                string[] timeEntranceTime = entranceTimeSplited[1].Split(':');

                int day = Int32.Parse(dateEntranceTime[0]);
                int month = Int32.Parse(dateEntranceTime[1]);
                int year = Int32.Parse(dateEntranceTime[2]);

                int hour = Int32.Parse(timeEntranceTime[0]);
                int minute = Int32.Parse(timeEntranceTime[1]);
                int seconds = 0;

                return new DateTime(year, month, day, hour, minute, seconds);
            }
            else
                return DateTime.Now; //we dont care what we return, cause the information will be erased (the card is out)
                
        }

        private void displayEntranceAndActualTime()
        {
            string entranceTime = "";
            if (CADw.read(entranceTimeBlock, ref entranceTime) == false)
            {
                textBoxMsg.Text = "Read value error!";
                return;
            }

            if (entranceTime != "") //sometimes the reader wont read, cause we just took out the card
            { 
                string[] time = entranceTime.Split('_');
                entranceTimeLabel.Text = time[0] + " " + time[1];
            
                System.DateTime actualTime = System.DateTime.Now;
                actualTimeLabel.Text = actualTime.ToString();
            }
        }

        private void displayCardInformation()
        {
            string cardId="";
            string carPatent = "";

            if (CADw.read(cardIdBlock, ref cardId) == false)
            {
                textBoxMsg.Text = "Read value error!";
                return;
            }

            
            if (CADw.read(carPatentBlock, ref carPatent) == false)
            {
                textBoxMsg.Text = "Read value error!";
                return;
            }
            // Display the value 
            cardIdLabel.Text = cardId + "";
            carPatentLabel.Text = carPatent;
        }

        private bool authenticateSector(int sector)
        {
            if (CADw.authenticate(sector) == false)
            {
                textBoxMsg.Text = "Authentication error!";
                return false;
            }
            return true;
        }

        private long displayAmountOfParkingCredit()
        {
            // Read the value of the 3 blocks in card, sums them and shows the sum in labelAmt
            long amount0 = 0;
            if (CADw.readValueBlock(amount0Block, ref amount0) == false)
            {
                textBoxMsg.Text = "Read value error!";
                return 0;
            }

            long amount1 = 0;
            if (CADw.readValueBlock(amount1Block, ref amount1) == false)
            {
                textBoxMsg.Text = "Read value error!";
                return 0;
            }

            long amount2 = 0;
            if (CADw.readValueBlock(amount2Block, ref amount2) == false)
            {
                textBoxMsg.Text = "Read value error!";
                return 0;
            }

            // Display the value 
            labelAmt.Text = toDollar(amount0 + amount1 + amount2);
            return amount0 + amount1 + amount2;
        }

        private void announceConnection()
        {
            connected = true;
            textBoxMsg.Text = "Good, have a look at your information";
        }

        private void announceDisconection()
        {
            // Connection lost.
            if (connected)
            {
                textBoxMsg.Text = "Place your card in reader to read card";
            }

            unDisplayInformation();
            connected = false;
            return;
        }

        private void unDisplayInformation()
        {
            cardInformationStaticLabel.Visible = false;
            cardIdStaticLabel.Visible = false;
            carPatentStaticLabel.Visible = false;
            entranceTimeStaticLabel.Visible = false;
            freeHoursStaticLabel.Visible = false;
            parkingCreditStaticLabel.Visible = false;
            actualTimeStaticLabel.Visible = false;
            actualParkingDebtStaticLabel.Visible = false;


            labelAmt.Text = "";
            quantityFreeHourslabel.Text = "";
            cardIdLabel.Text = "";
            carPatentLabel.Text = "";
            entranceTimeLabel.Text = "";
            actualTimeLabel.Text = "";
            actualParkingDebtLabel.Text = "";
        }

        private void resetMemoryValues()
        {
            CADw.write(cardIdBlock, "");
            CADw.write(carPatentBlock, "");
            CADw.updateValueBlock(amount0Block, 0);
            CADw.updateValueBlock(amount1Block, 0);
            CADw.updateValueBlock(amount2Block, 0);
        }

        private string calculateFreeParkingHours(long credit)
        {
            if (credit >= combo1MoneyNeeded)
            {
                return combo1freeHours+"";
            }

            if (credit >= combo2MoneyNeeded)
            {
                return combo2freeHours + "";
            }

            else
            {
                return "0";
            }
        }

        private string toDollar(long amount)
        {
            /* The value stored in the card is in cents. Convert the value to dollar
             * */

            string str = "";

            if (amount <= 0)
                str = "0";
            else if (amount < 10)
                str = "0.0" + amount.ToString();
            else if (amount < 100)
                str = "0." + amount.ToString();
            else
            {
                int dollar = (int)amount / 100;
                int cent = (int)amount % 100;

                str = dollar.ToString();
                str += ".";
                if (cent == 0)
                    str += "00";
                else
                    str += cent.ToString();
            }
            return str;
        }

        

    }
}
