namespace imseWCard2
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Configure = new System.Windows.Forms.TabPage();
            this.actualParkingDebtLabel = new System.Windows.Forms.Label();
            this.actualParkingDebtStaticLabel = new System.Windows.Forms.Label();
            this.actualTimeLabel = new System.Windows.Forms.Label();
            this.actualTimeStaticLabel = new System.Windows.Forms.Label();
            this.entranceTimeLabel = new System.Windows.Forms.Label();
            this.entranceTimeStaticLabel = new System.Windows.Forms.Label();
            this.carPatentLabel = new System.Windows.Forms.Label();
            this.carPatentStaticLabel = new System.Windows.Forms.Label();
            this.labelAmt = new System.Windows.Forms.Label();
            this.quantityFreeHourslabel = new System.Windows.Forms.Label();
            this.freeHoursStaticLabel = new System.Windows.Forms.Label();
            this.cardIdLabel = new System.Windows.Forms.Label();
            this.cardInformationStaticLabel = new System.Windows.Forms.Label();
            this.cardIdStaticLabel = new System.Windows.Forms.Label();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.parkingCreditStaticLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.Configure.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Configure);
            this.tabControl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(374, 549);
            this.tabControl.TabIndex = 0;

            // 
            // Configure
            // 
            this.Configure.BackColor = System.Drawing.Color.LightBlue;
            this.Configure.Controls.Add(this.actualParkingDebtLabel);
            this.Configure.Controls.Add(this.actualParkingDebtStaticLabel);
            this.Configure.Controls.Add(this.actualTimeLabel);
            this.Configure.Controls.Add(this.actualTimeStaticLabel);
            this.Configure.Controls.Add(this.entranceTimeLabel);
            this.Configure.Controls.Add(this.entranceTimeStaticLabel);
            this.Configure.Controls.Add(this.carPatentLabel);
            this.Configure.Controls.Add(this.carPatentStaticLabel);
            this.Configure.Controls.Add(this.labelAmt);
            this.Configure.Controls.Add(this.quantityFreeHourslabel);
            this.Configure.Controls.Add(this.freeHoursStaticLabel);
            this.Configure.Controls.Add(this.cardIdLabel);
            this.Configure.Controls.Add(this.cardInformationStaticLabel);
            this.Configure.Controls.Add(this.cardIdStaticLabel);
            this.Configure.Controls.Add(this.textBoxMsg);
            this.Configure.Controls.Add(this.parkingCreditStaticLabel);
            this.Configure.Controls.Add(this.label1);
            this.Configure.Location = new System.Drawing.Point(4, 31);
            this.Configure.Name = "Configure";
            this.Configure.Padding = new System.Windows.Forms.Padding(3);
            this.Configure.Size = new System.Drawing.Size(366, 514);
            this.Configure.TabIndex = 0;
            this.Configure.Text = "Public Application";
            // 
            // actualParkingDebtLabel
            // 
            this.actualParkingDebtLabel.AutoSize = true;
            this.actualParkingDebtLabel.Location = new System.Drawing.Point(13, 437);
            this.actualParkingDebtLabel.Name = "actualParkingDebtLabel";
            this.actualParkingDebtLabel.Size = new System.Drawing.Size(186, 22);
            this.actualParkingDebtLabel.TabIndex = 24;
            this.actualParkingDebtLabel.Text = "                ";
            // 
            // actualParkingDebtStaticLabel
            // 
            this.actualParkingDebtStaticLabel.AutoSize = true;
            this.actualParkingDebtStaticLabel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualParkingDebtStaticLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.actualParkingDebtStaticLabel.Location = new System.Drawing.Point(13, 403);
            this.actualParkingDebtStaticLabel.Name = "actualParkingDebtStaticLabel";
            this.actualParkingDebtStaticLabel.Size = new System.Drawing.Size(257, 23);
            this.actualParkingDebtStaticLabel.TabIndex = 23;
            this.actualParkingDebtStaticLabel.Text = "Actual parking debt";
            // 
            // actualTimeLabel
            // 
            this.actualTimeLabel.AutoSize = true;
            this.actualTimeLabel.Location = new System.Drawing.Point(13, 367);
            this.actualTimeLabel.Name = "actualTimeLabel";
            this.actualTimeLabel.Size = new System.Drawing.Size(186, 22);
            this.actualTimeLabel.TabIndex = 22;
            this.actualTimeLabel.Text = "                ";
            // 
            // actualTimeStaticLabel
            // 
            this.actualTimeStaticLabel.AutoSize = true;
            this.actualTimeStaticLabel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualTimeStaticLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.actualTimeStaticLabel.Location = new System.Drawing.Point(13, 333);
            this.actualTimeStaticLabel.Name = "actualTimeStaticLabel";
            this.actualTimeStaticLabel.Size = new System.Drawing.Size(153, 23);
            this.actualTimeStaticLabel.TabIndex = 21;
            this.actualTimeStaticLabel.Text = "Actual time";
            // 
            // entranceTimeLabel
            // 
            this.entranceTimeLabel.AutoSize = true;
            this.entranceTimeLabel.Location = new System.Drawing.Point(13, 293);
            this.entranceTimeLabel.Name = "entranceTimeLabel";
            this.entranceTimeLabel.Size = new System.Drawing.Size(186, 22);
            this.entranceTimeLabel.TabIndex = 20;
            this.entranceTimeLabel.Text = "                ";
            // 
            // entranceTimeStaticLabel
            // 
            this.entranceTimeStaticLabel.AutoSize = true;
            this.entranceTimeStaticLabel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entranceTimeStaticLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.entranceTimeStaticLabel.Location = new System.Drawing.Point(13, 259);
            this.entranceTimeStaticLabel.Name = "entranceTimeStaticLabel";
            this.entranceTimeStaticLabel.Size = new System.Drawing.Size(179, 23);
            this.entranceTimeStaticLabel.TabIndex = 19;
            this.entranceTimeStaticLabel.Text = "Entrance time";
            // 
            // carPatentLabel
            // 
            this.carPatentLabel.AutoSize = true;
            this.carPatentLabel.Location = new System.Drawing.Point(149, 152);
            this.carPatentLabel.Name = "carPatentLabel";
            this.carPatentLabel.Size = new System.Drawing.Size(153, 22);
            this.carPatentLabel.TabIndex = 17;
            this.carPatentLabel.Text = "             ";
            // 
            // carPatentStaticLabel
            // 
            this.carPatentStaticLabel.AutoSize = true;
            this.carPatentStaticLabel.Location = new System.Drawing.Point(12, 152);
            this.carPatentStaticLabel.Name = "carPatentStaticLabel";
            this.carPatentStaticLabel.Size = new System.Drawing.Size(131, 22);
            this.carPatentStaticLabel.TabIndex = 16;
            this.carPatentStaticLabel.Text = "Car Patent:";
            // 
            // labelAmt
            // 
            this.labelAmt.AutoSize = true;
            this.labelAmt.Location = new System.Drawing.Point(193, 194);
            this.labelAmt.Name = "labelAmt";
            this.labelAmt.Size = new System.Drawing.Size(120, 22);
            this.labelAmt.TabIndex = 15;
            this.labelAmt.Text = "          ";
            // 
            // quantityFreeHourslabel
            // 
            this.quantityFreeHourslabel.AutoSize = true;
            this.quantityFreeHourslabel.Location = new System.Drawing.Point(237, 224);
            this.quantityFreeHourslabel.Name = "quantityFreeHourslabel";
            this.quantityFreeHourslabel.Size = new System.Drawing.Size(98, 22);
            this.quantityFreeHourslabel.TabIndex = 14;
            this.quantityFreeHourslabel.Text = "        ";
            // 
            // freeHoursStaticLabel
            // 
            this.freeHoursStaticLabel.AutoSize = true;
            this.freeHoursStaticLabel.Location = new System.Drawing.Point(12, 224);
            this.freeHoursStaticLabel.Name = "freeHoursStaticLabel";
            this.freeHoursStaticLabel.Size = new System.Drawing.Size(219, 22);
            this.freeHoursStaticLabel.TabIndex = 13;
            this.freeHoursStaticLabel.Text = "Free Parking Hours:";
            // 
            // cardIdLabel
            // 
            this.cardIdLabel.AutoSize = true;
            this.cardIdLabel.Location = new System.Drawing.Point(104, 120);
            this.cardIdLabel.Name = "cardIdLabel";
            this.cardIdLabel.Size = new System.Drawing.Size(153, 22);
            this.cardIdLabel.TabIndex = 10;
            this.cardIdLabel.Text = "             ";
            // 
            // cardInformationStaticLabel
            // 
            this.cardInformationStaticLabel.AutoSize = true;
            this.cardInformationStaticLabel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardInformationStaticLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cardInformationStaticLabel.Location = new System.Drawing.Point(13, 86);
            this.cardInformationStaticLabel.Name = "cardInformationStaticLabel";
            this.cardInformationStaticLabel.Size = new System.Drawing.Size(218, 23);
            this.cardInformationStaticLabel.TabIndex = 9;
            this.cardInformationStaticLabel.Text = "Card Information";
            // 
            // cardIdStaticLabel
            // 
            this.cardIdStaticLabel.AutoSize = true;
            this.cardIdStaticLabel.Location = new System.Drawing.Point(11, 120);
            this.cardIdStaticLabel.Name = "cardIdStaticLabel";
            this.cardIdStaticLabel.Size = new System.Drawing.Size(87, 22);
            this.cardIdStaticLabel.TabIndex = 8;
            this.cardIdStaticLabel.Text = "CardID:";
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMsg.Location = new System.Drawing.Point(16, 40);
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.Size = new System.Drawing.Size(324, 31);
            this.textBoxMsg.TabIndex = 1;
            // 
            // parkingCreditStaticLabel
            // 
            this.parkingCreditStaticLabel.AutoSize = true;
            this.parkingCreditStaticLabel.Location = new System.Drawing.Point(12, 194);
            this.parkingCreditStaticLabel.Name = "parkingCreditStaticLabel";
            this.parkingCreditStaticLabel.Size = new System.Drawing.Size(175, 22);
            this.parkingCreditStaticLabel.TabIndex = 1;
            this.parkingCreditStaticLabel.Text = "Parking Credit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(398, 574);
            this.Controls.Add(this.tabControl);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parking System - Public App";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl.ResumeLayout(false);
            this.Configure.ResumeLayout(false);
            this.Configure.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Configure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxMsg;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label cardIdLabel;
        private System.Windows.Forms.Label cardInformationStaticLabel;
        private System.Windows.Forms.Label cardIdStaticLabel;
        private System.Windows.Forms.Label quantityFreeHourslabel;
        private System.Windows.Forms.Label labelAmt;
        private System.Windows.Forms.Label carPatentLabel;
        private System.Windows.Forms.Label carPatentStaticLabel;
        private System.Windows.Forms.Label entranceTimeLabel;
        private System.Windows.Forms.Label entranceTimeStaticLabel;
        private System.Windows.Forms.Label freeHoursStaticLabel;
        private System.Windows.Forms.Label parkingCreditStaticLabel;
        private System.Windows.Forms.Label actualTimeLabel;
        private System.Windows.Forms.Label actualTimeStaticLabel;
        private System.Windows.Forms.Label actualParkingDebtLabel;
        private System.Windows.Forms.Label actualParkingDebtStaticLabel;
    }
}

