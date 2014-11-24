/*=======================================================================================================================
    Parking System Project - IMSE3019 - Shop Application

    Created by  : Felipe Alamos
    Date        : 2nd December 2014
    Remark      :                   
        1. The project is based in the project developed by Bill Chan, imseWCard2, for IMSE3019 Smart Card Laboratory.

        2. The reference imseWSC1K should be added.

        3. The current application enables a Shop Store to administrate the parking card.

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
        private int PricePerHour = 30;

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
            textBoxMsg.Text = "Reader initialization successful.";
            timer1.Enabled = true;
            timer2.Enabled = false;
            timer3.Enabled = false;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* initialize timers and other values when the user switch
             * between the three main functions: configure, credit and debit.
             * Timer1, timer2 and timer3 are used for configure, credit and debit
             * respectively.
             * */

            switch (tabControl.SelectedIndex)
            {
                case 0:
                    timer1.Enabled = true;
                    timer2.Enabled = false;
                    timer3.Enabled = false;
                    transectionDone = false;
                    labelAmt.Text = "";
                    break;
                case 1:
                    timer1.Enabled = false;
                    timer2.Enabled = true;
                    timer3.Enabled = false;
                    transectionDone = false;
                    radioButtonCreditChange.Checked = true;
                    break;
                case 2:
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    timer3.Enabled = true;
                    radioButtonDebitChange.Checked = true;
                    break;
            }
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

                if (authenticateSector(informationSector))
                  displayCardInformation();

                // Authenticate before reading or writing to a sector
                if (authenticateSector(amountsSector))
                {
                    // Disable "Charge" button if Amount quantity is 0.
                    disableOrEnableChargeButton();

                    long amount = displayAmountOfParkingCredit();

                    //Display amout of free parking hours available
                    quantityFreeHourslabel.Text = calculateFreeParkingHours(amount);
                }
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
            textBoxMsg.Text = "Connected.";
        }

        private void announceDisconection()
        {
            // Connection lost.
            if (connected)
            {
                textBoxMsg.Text = "Lost connection!";
                labelAmt.Text = "";
                quantityFreeHourslabel.Text = "";
                cardIdLabel.Text = "";
                carPatentLabel.Text = "";
            }
            btnConfigGo.Enabled = false;
            connected = false;
            return;
        }

        private void disableOrEnableChargeButton()
        {
            if (textBoxConfigAmt.Text.Equals("0") || textBoxConfigAmt.Text.Equals(""))
            {
                btnConfigGo.Enabled = false;
            }
            else
            {
                btnConfigGo.Enabled = true;
            }
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
                return "None";
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

        private void btnConfigGo_Click(object sender, EventArgs e)
        {
            /* Initialize a card's value
             * */
            long Amount;
            int tempInt;

            // Check whether the value in the text box is valid.
            if (!int.TryParse(textBoxConfigAmt.Text, out tempInt))
            {
                textBoxConfigAmt.Focus();
                textBoxConfigAmt.Text = "0";
                return;
            }
            // convert to cents and store into card
            Amount = 100*Convert.ToInt32(textBoxConfigAmt.Text);
            
            //@fhalamos
            //We will save amount only if it is bigger than any of the other 3 amounts.
            long amount0 = 0;
            CADw.readValueBlock(amount0Block, ref amount0);
            long amount1 = 0;
            CADw.readValueBlock(amount1Block, ref amount1);
            long amount2 = 0;
            CADw.readValueBlock(amount2Block, ref amount2);
            
            //We need to know which is the smallest amount actually saved
            long min0 = Math.Min(amount0, amount1);
            long min = Math.Min(min0, amount2);

            if (Amount > min)
            {
                if (min == amount0)
                    CADw.updateValueBlock(amount0Block, Amount);
                else if (min == amount1)
                    CADw.updateValueBlock(amount1Block, Amount);
                else if (min == amount2)
                    CADw.updateValueBlock(amount2Block, Amount);
                

                System.Windows.Forms.MessageBox.Show(toDollar(Amount) + " dollars added to your parking credit!");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Ups! Your purchase is too small to be saved, it is smaller than any of your 3 biggest purchases");
            }

            textBoxConfigAmt.Text = "0";
        }




        //****************OUT OF USE ****************************
        private void btn100_Click(object sender, EventArgs e)
        {
            textBoxCAmt.Text = "100";
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            textBoxCAmt.Text = "200";
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            textBoxCAmt.Text = "500";
        }

        private void btn800_Click(object sender, EventArgs e)
        {
            textBoxCAmt.Text = "800";
        }

        private void btn1000_Click(object sender, EventArgs e)
        {
            textBoxCAmt.Text = "1000";
        }

        private void btn2000_Click(object sender, EventArgs e)
        {
            textBoxCAmt.Text = "2000";
        }

        private void addDigit(string d)
        { // Append a digit to the text box textBoxDAmt
            // The value should contains not more than 2 decimal points.
            string s = textBoxDAmt.Text;
            if (s.Contains("."))
            {
                if (s.IndexOf(".") + 2 < s.Length)
                    return;
            }
            if (s.Length == 1 && s[0] == '0')
                textBoxDAmt.Text = d;
            else
                textBoxDAmt.Text = s + d;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            addDigit("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            addDigit("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            addDigit("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            addDigit("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            addDigit("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            addDigit("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            addDigit("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            addDigit("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            addDigit("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            addDigit("0");
        }

        private void btnCLR_Click(object sender, EventArgs e)
        {
            textBoxDAmt.Text = "0";
        }

        private void btnDOT_Click(object sender, EventArgs e)
        {
            string s = textBoxDAmt.Text;
            if (s.Contains(".") == false)
                textBoxDAmt.Text = s + ".";
        }

        private void radioButtonDebitReady_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDebitReady.Checked == false)
                return;

            /* The value in the text box textBoxDAmt represents the amount to be
             * debit from the card in dollar. If radio button "ready" is selected
             * and the value is positive, disable input buttons and then enable 
             * the timer.
             * */

            double value = 0.0;

            if (textBoxDAmt.Text.Length > 0)
                value = Convert.ToDouble(textBoxDAmt.Text);

            if (value <= 0)
            {
                radioButtonDebitChange.Select();
                return;
            }

            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnDOT.Enabled = false;
            btn0.Enabled = false;
            btnCLR.Enabled = false;
            timer3.Enabled = true;
        }

        private void radioButtonDebitChange_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDebitChange.Checked == false)
                return;

            /* If radio button "change" is selected, enable input buttons.
             * and disable timer.
             * */

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnDOT.Enabled = true;
            btn0.Enabled = true;
            btnCLR.Enabled = true;
            textBoxDAmt.Text = "0";
            timer3.Enabled = false;
        }

        private void radioButtonCreditReady_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCreditReady.Checked == false)
                return;

            /* The value in the text box textBoxCAmt represents the amount to be
             * credit to the card in dollar. If radio button "ready" is selected 
             * and the value is positive, disable input buttons.
             * */
            double value = 0.0;

            if (textBoxCAmt.Text.Length > 0)
                value = Convert.ToDouble(textBoxCAmt.Text);

            if (value <= 0)
            {
                radioButtonCreditChange.Select();
                return;
            }

            btn100.Enabled = false;
            btn200.Enabled = false;
            btn500.Enabled = false;
            btn800.Enabled = false;
            btn1000.Enabled = false;
            btn2000.Enabled = false;
            btnCredit.Enabled = true;
        }

        private void radioButtonCreditChange_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCreditChange.Checked == false)
                return;
            /* If radio button "change" is selected, enable input buttons.
             * */
            btn100.Enabled = true;
            btn200.Enabled = true;
            btn500.Enabled = true;
            btn800.Enabled = true;
            btn1000.Enabled = true;
            btn2000.Enabled = true;
            textBoxCAmt.Text = "0";
            btnCredit.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!CADw.connect())
            {
                // Connection lost.
                if (connected)
                {
                    textBoxMsg.Text = "Lose connection!";
                    textBoxCBalance.Text = "";
                    radioButtonCreditChange.Select();
                }
                connected = false;
                return;
            }
            else
            {
                // Connected
                if (!connected)
                {
                    connected = true;
                    textBoxMsg.Text = "Connected.";
                } 

                // Authenticate before reading or writing
                if (CADw.authenticate(amountsSector) == false)
                {
                    textBoxMsg.Text = "Authentication error!";
                    return;
                }

                //Read value from the card
                long amount = 0;
                if (CADw.readValueBlock(amount2Block, ref amount) == false)
                {
                    textBoxMsg.Text = "Read value error!";
                    return;
                }

                // Display the value
                textBoxCBalance.Text = toDollar(amount);


            }
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            /* Add value to the card
             * */

            // Check whether the value in the text box is valid.
            double value = 0.0;
            if (textBoxCAmt.Text.Length > 0)
                value = Convert.ToDouble(textBoxCAmt.Text);

            if (value <= 0)
            {
                radioButtonCreditChange.Select();
                return;
            }
            /* The value in the text box is in dollar. Convert to cents and 
             * add to the card.
             * */
            int amount = Convert.ToInt32(100.0 * value);
            if (CADw.incValueBlock(amount2Block, amount) == false)
                textBoxMsg.Text = "Value increment error!";
        }

        private void timer3_Tick(object sender, EventArgs e)
        {            
            if (!CADw.connect())
            {
                // Connection lost.
                if (connected)
                {
                    textBoxMsg.Text = "Lose connection!";
                    textBoxDBalance.Text = "";
                    transectionDone = false;
                }
                connected = false;
                return;
            }
            else
            {
                // Connected
                if (!connected)
                {
                    connected = true;
                    textBoxDBalance.Text = "";
                    textBoxMsg.Text = "Connected.";
                } 
                
                // Authenticate before reading or writing
                if (CADw.authenticate(amountsSector) == false)
                {
                    textBoxMsg.Text = "Authentication error!";
                    return;
                }

                // Read value from the card
                long amount = 0;
                if (CADw.readValueBlock(amount2Block, ref amount) == false)
                {
                    textBoxMsg.Text = "Read value error!";
                    return;
                }

                // If ready to debit and the transaction is not done in previous timer cycle
                
                if (radioButtonDebitReady.Checked == true && transectionDone == false)
                {
                    // Check whether the value in the text box is valid
                    double value = 0.0;
                    if (textBoxDAmt.Text.Length > 0)
                        value = Convert.ToDouble(textBoxDAmt.Text);

                    if (value <= 0)
                    {
                        radioButtonDebitChange.Checked = true;
                        return;
                    }

                    long newAmount = Convert.ToInt32(100.0 * value);

                    // Check whether there are enough money in the card
                    if (newAmount > amount)
                    {
                        textBoxMsg.Text = "Balance not enough!";
                        return;
                    }

                    // Subtract theamount from the card.
                    if (CADw.decValueBlock(amount2Block, newAmount) == false)
                    {
                        textBoxMsg.Text = "Value decrement error!";
                        return;
                    }
                    transectionDone = true;
                }

                // Read value from the card
                if (CADw.readValueBlock(amount2Block, ref amount) == false)
                {
                    textBoxMsg.Text = "Read value error!";
                    return;
                }

                // Display the value
                textBoxDBalance.Text = toDollar(amount);
            }

        }

        private void btnCredit_EnabledChanged(object sender, EventArgs e)
        {
            /* Change colour of the credit button.
             * Pink if ready to credit. Otherwise, blue.
             * */

            if (btnCredit.Enabled == true)
            {
                btnCredit.BackColor = Color.Pink;
            }
            else
            {
                btnCredit.BackColor = Color.LightBlue;
            }
        }

        //****************END OUT OF USE ****************************
    }
}
