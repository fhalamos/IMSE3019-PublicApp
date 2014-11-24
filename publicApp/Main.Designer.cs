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
            this.label10 = new System.Windows.Forms.Label();
            this.labelAmt = new System.Windows.Forms.Label();
            this.quantityFreeHourslabel = new System.Windows.Forms.Label();
            this.freeHourslabel = new System.Windows.Forms.Label();
            this.cardIdLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Credit = new System.Windows.Forms.TabPage();
            this.btnCredit = new System.Windows.Forms.Button();
            this.radioButtonCreditReady = new System.Windows.Forms.RadioButton();
            this.radioButtonCreditChange = new System.Windows.Forms.RadioButton();
            this.btn2000 = new System.Windows.Forms.Button();
            this.btn1000 = new System.Windows.Forms.Button();
            this.btn800 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.textBoxCAmt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Debit = new System.Windows.Forms.TabPage();
            this.radioButtonDebitReady = new System.Windows.Forms.RadioButton();
            this.radioButtonDebitChange = new System.Windows.Forms.RadioButton();
            this.btnCLR = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDOT = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.textBoxDAmt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.Configure.SuspendLayout();
            this.Credit.SuspendLayout();
            this.Debit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Configure);
            this.tabControl.Controls.Add(this.Credit);
            this.tabControl.Controls.Add(this.Debit);
            this.tabControl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(374, 549);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
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
            this.Configure.Controls.Add(this.label10);
            this.Configure.Controls.Add(this.labelAmt);
            this.Configure.Controls.Add(this.quantityFreeHourslabel);
            this.Configure.Controls.Add(this.freeHourslabel);
            this.Configure.Controls.Add(this.cardIdLabel);
            this.Configure.Controls.Add(this.label8);
            this.Configure.Controls.Add(this.label3);
            this.Configure.Controls.Add(this.textBoxMsg);
            this.Configure.Controls.Add(this.label2);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Car Patent:";
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
            // freeHourslabel
            // 
            this.freeHourslabel.AutoSize = true;
            this.freeHourslabel.Location = new System.Drawing.Point(12, 224);
            this.freeHourslabel.Name = "freeHourslabel";
            this.freeHourslabel.Size = new System.Drawing.Size(219, 22);
            this.freeHourslabel.TabIndex = 13;
            this.freeHourslabel.Text = "Free Parking Hours:";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(13, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Card Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "CardID:";
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMsg.Location = new System.Drawing.Point(16, 40);
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.Size = new System.Drawing.Size(324, 31);
            this.textBoxMsg.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parking Credit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reader Status";
            // 
            // Credit
            // 
            this.Credit.BackColor = System.Drawing.Color.Silver;
            this.Credit.Controls.Add(this.btnCredit);
            this.Credit.Controls.Add(this.radioButtonCreditReady);
            this.Credit.Controls.Add(this.radioButtonCreditChange);
            this.Credit.Controls.Add(this.btn2000);
            this.Credit.Controls.Add(this.btn1000);
            this.Credit.Controls.Add(this.btn800);
            this.Credit.Controls.Add(this.btn500);
            this.Credit.Controls.Add(this.btn200);
            this.Credit.Controls.Add(this.btn100);
            this.Credit.Controls.Add(this.textBoxCAmt);
            this.Credit.Controls.Add(this.label5);
            this.Credit.Controls.Add(this.textBoxCBalance);
            this.Credit.Controls.Add(this.label4);
            this.Credit.Location = new System.Drawing.Point(4, 31);
            this.Credit.Name = "Credit";
            this.Credit.Padding = new System.Windows.Forms.Padding(3);
            this.Credit.Size = new System.Drawing.Size(366, 514);
            this.Credit.TabIndex = 1;
            this.Credit.Text = "Credit";
            this.Credit.UseVisualStyleBackColor = true;
            // 
            // btnCredit
            // 
            this.btnCredit.BackColor = System.Drawing.Color.LightBlue;
            this.btnCredit.Enabled = false;
            this.btnCredit.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredit.Location = new System.Drawing.Point(189, 376);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(149, 63);
            this.btnCredit.TabIndex = 26;
            this.btnCredit.Text = "Go";
            this.btnCredit.UseVisualStyleBackColor = false;
            this.btnCredit.EnabledChanged += new System.EventHandler(this.btnCredit_EnabledChanged);
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // radioButtonCreditReady
            // 
            this.radioButtonCreditReady.AutoSize = true;
            this.radioButtonCreditReady.Location = new System.Drawing.Point(24, 411);
            this.radioButtonCreditReady.Name = "radioButtonCreditReady";
            this.radioButtonCreditReady.Size = new System.Drawing.Size(83, 26);
            this.radioButtonCreditReady.TabIndex = 25;
            this.radioButtonCreditReady.Text = "Ready";
            this.radioButtonCreditReady.UseVisualStyleBackColor = true;
            this.radioButtonCreditReady.CheckedChanged += new System.EventHandler(this.radioButtonCreditReady_CheckedChanged);
            // 
            // radioButtonCreditChange
            // 
            this.radioButtonCreditChange.AutoSize = true;
            this.radioButtonCreditChange.Checked = true;
            this.radioButtonCreditChange.Location = new System.Drawing.Point(24, 376);
            this.radioButtonCreditChange.Name = "radioButtonCreditChange";
            this.radioButtonCreditChange.Size = new System.Drawing.Size(94, 26);
            this.radioButtonCreditChange.TabIndex = 24;
            this.radioButtonCreditChange.TabStop = true;
            this.radioButtonCreditChange.Text = "Change";
            this.radioButtonCreditChange.UseVisualStyleBackColor = true;
            this.radioButtonCreditChange.CheckedChanged += new System.EventHandler(this.radioButtonCreditChange_CheckedChanged);
            // 
            // btn2000
            // 
            this.btn2000.Location = new System.Drawing.Point(189, 295);
            this.btn2000.Name = "btn2000";
            this.btn2000.Size = new System.Drawing.Size(149, 43);
            this.btn2000.TabIndex = 9;
            this.btn2000.Text = "$2000";
            this.btn2000.UseVisualStyleBackColor = true;
            this.btn2000.Click += new System.EventHandler(this.btn2000_Click);
            // 
            // btn1000
            // 
            this.btn1000.Location = new System.Drawing.Point(189, 234);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(149, 43);
            this.btn1000.TabIndex = 8;
            this.btn1000.Text = "$1000";
            this.btn1000.UseVisualStyleBackColor = true;
            this.btn1000.Click += new System.EventHandler(this.btn1000_Click);
            // 
            // btn800
            // 
            this.btn800.Location = new System.Drawing.Point(189, 176);
            this.btn800.Name = "btn800";
            this.btn800.Size = new System.Drawing.Size(149, 43);
            this.btn800.TabIndex = 7;
            this.btn800.Text = "$800";
            this.btn800.UseVisualStyleBackColor = true;
            this.btn800.Click += new System.EventHandler(this.btn800_Click);
            // 
            // btn500
            // 
            this.btn500.Location = new System.Drawing.Point(24, 295);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(149, 43);
            this.btn500.TabIndex = 6;
            this.btn500.Text = "$500";
            this.btn500.UseVisualStyleBackColor = true;
            this.btn500.Click += new System.EventHandler(this.btn500_Click);
            // 
            // btn200
            // 
            this.btn200.Location = new System.Drawing.Point(24, 233);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(149, 43);
            this.btn200.TabIndex = 5;
            this.btn200.Text = "$200";
            this.btn200.UseVisualStyleBackColor = true;
            this.btn200.Click += new System.EventHandler(this.btn200_Click);
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(24, 176);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(149, 43);
            this.btn100.TabIndex = 4;
            this.btn100.Text = "$100";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // textBoxCAmt
            // 
            this.textBoxCAmt.Location = new System.Drawing.Point(21, 111);
            this.textBoxCAmt.Name = "textBoxCAmt";
            this.textBoxCAmt.ReadOnly = true;
            this.textBoxCAmt.Size = new System.Drawing.Size(317, 29);
            this.textBoxCAmt.TabIndex = 3;
            this.textBoxCAmt.Text = "0";
            this.textBoxCAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Credit Amount";
            // 
            // textBoxCBalance
            // 
            this.textBoxCBalance.Location = new System.Drawing.Point(21, 35);
            this.textBoxCBalance.Name = "textBoxCBalance";
            this.textBoxCBalance.ReadOnly = true;
            this.textBoxCBalance.Size = new System.Drawing.Size(317, 29);
            this.textBoxCBalance.TabIndex = 1;
            this.textBoxCBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Balance";
            // 
            // Debit
            // 
            this.Debit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Debit.Controls.Add(this.radioButtonDebitReady);
            this.Debit.Controls.Add(this.radioButtonDebitChange);
            this.Debit.Controls.Add(this.btnCLR);
            this.Debit.Controls.Add(this.btn0);
            this.Debit.Controls.Add(this.btnDOT);
            this.Debit.Controls.Add(this.btn9);
            this.Debit.Controls.Add(this.btn8);
            this.Debit.Controls.Add(this.btn7);
            this.Debit.Controls.Add(this.btn6);
            this.Debit.Controls.Add(this.btn5);
            this.Debit.Controls.Add(this.btn4);
            this.Debit.Controls.Add(this.btn3);
            this.Debit.Controls.Add(this.btn2);
            this.Debit.Controls.Add(this.btn1);
            this.Debit.Controls.Add(this.textBoxDAmt);
            this.Debit.Controls.Add(this.label6);
            this.Debit.Controls.Add(this.textBoxDBalance);
            this.Debit.Controls.Add(this.label7);
            this.Debit.Location = new System.Drawing.Point(4, 31);
            this.Debit.Name = "Debit";
            this.Debit.Padding = new System.Windows.Forms.Padding(3);
            this.Debit.Size = new System.Drawing.Size(366, 514);
            this.Debit.TabIndex = 2;
            this.Debit.Text = "Debit";
            this.Debit.UseVisualStyleBackColor = true;
            // 
            // radioButtonDebitReady
            // 
            this.radioButtonDebitReady.AutoSize = true;
            this.radioButtonDebitReady.Location = new System.Drawing.Point(259, 229);
            this.radioButtonDebitReady.Name = "radioButtonDebitReady";
            this.radioButtonDebitReady.Size = new System.Drawing.Size(83, 26);
            this.radioButtonDebitReady.TabIndex = 23;
            this.radioButtonDebitReady.Text = "Ready";
            this.radioButtonDebitReady.UseVisualStyleBackColor = true;
            this.radioButtonDebitReady.CheckedChanged += new System.EventHandler(this.radioButtonDebitReady_CheckedChanged);
            // 
            // radioButtonDebitChange
            // 
            this.radioButtonDebitChange.AutoSize = true;
            this.radioButtonDebitChange.Checked = true;
            this.radioButtonDebitChange.Location = new System.Drawing.Point(259, 180);
            this.radioButtonDebitChange.Name = "radioButtonDebitChange";
            this.radioButtonDebitChange.Size = new System.Drawing.Size(94, 26);
            this.radioButtonDebitChange.TabIndex = 22;
            this.radioButtonDebitChange.TabStop = true;
            this.radioButtonDebitChange.Text = "Change";
            this.radioButtonDebitChange.UseVisualStyleBackColor = true;
            this.radioButtonDebitChange.CheckedChanged += new System.EventHandler(this.radioButtonDebitChange_CheckedChanged);
            // 
            // btnCLR
            // 
            this.btnCLR.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLR.Location = new System.Drawing.Point(177, 394);
            this.btnCLR.Name = "btnCLR";
            this.btnCLR.Size = new System.Drawing.Size(72, 73);
            this.btnCLR.TabIndex = 21;
            this.btnCLR.Text = "Clear";
            this.btnCLR.UseVisualStyleBackColor = true;
            this.btnCLR.Click += new System.EventHandler(this.btnCLR_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(99, 394);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(72, 73);
            this.btn0.TabIndex = 19;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnDOT
            // 
            this.btnDOT.Location = new System.Drawing.Point(21, 394);
            this.btnDOT.Name = "btnDOT";
            this.btnDOT.Size = new System.Drawing.Size(72, 73);
            this.btnDOT.TabIndex = 18;
            this.btnDOT.Text = ".";
            this.btnDOT.UseVisualStyleBackColor = true;
            this.btnDOT.Click += new System.EventHandler(this.btnDOT_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(177, 315);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(72, 73);
            this.btn9.TabIndex = 17;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(99, 315);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(72, 73);
            this.btn8.TabIndex = 16;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(21, 315);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(72, 73);
            this.btn7.TabIndex = 15;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(177, 236);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(72, 73);
            this.btn6.TabIndex = 14;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(99, 236);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(72, 73);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(21, 236);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(72, 73);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(177, 157);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(72, 73);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(99, 157);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(72, 73);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(21, 157);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(72, 73);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // textBoxDAmt
            // 
            this.textBoxDAmt.Location = new System.Drawing.Point(21, 111);
            this.textBoxDAmt.Name = "textBoxDAmt";
            this.textBoxDAmt.ReadOnly = true;
            this.textBoxDAmt.Size = new System.Drawing.Size(317, 29);
            this.textBoxDAmt.TabIndex = 8;
            this.textBoxDAmt.Text = "0";
            this.textBoxDAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Debit Amount";
            // 
            // textBoxDBalance
            // 
            this.textBoxDBalance.Location = new System.Drawing.Point(21, 35);
            this.textBoxDBalance.Name = "textBoxDBalance";
            this.textBoxDBalance.ReadOnly = true;
            this.textBoxDBalance.Size = new System.Drawing.Size(317, 29);
            this.textBoxDBalance.TabIndex = 6;
            this.textBoxDBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Balance";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(398, 574);
            this.Controls.Add(this.tabControl);
            this.Name = "Main";
            this.Text = "Parking System - Public App";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl.ResumeLayout(false);
            this.Configure.ResumeLayout(false);
            this.Configure.PerformLayout();
            this.Credit.ResumeLayout(false);
            this.Credit.PerformLayout();
            this.Debit.ResumeLayout(false);
            this.Debit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Configure;
        private System.Windows.Forms.TabPage Credit;
        private System.Windows.Forms.TabPage Debit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.TextBox textBoxCAmt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn1000;
        private System.Windows.Forms.Button btn800;
        private System.Windows.Forms.TextBox textBoxDAmt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDOT;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnCLR;
        private System.Windows.Forms.RadioButton radioButtonDebitReady;
        private System.Windows.Forms.RadioButton radioButtonDebitChange;
        private System.Windows.Forms.Button btn2000;
        private System.Windows.Forms.RadioButton radioButtonCreditReady;
        private System.Windows.Forms.RadioButton radioButtonCreditChange;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxMsg;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Label cardIdLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label quantityFreeHourslabel;
        private System.Windows.Forms.Label labelAmt;
        private System.Windows.Forms.Label carPatentLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label entranceTimeLabel;
        private System.Windows.Forms.Label entranceTimeStaticLabel;
        private System.Windows.Forms.Label freeHourslabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label actualTimeLabel;
        private System.Windows.Forms.Label actualTimeStaticLabel;
        private System.Windows.Forms.Label actualParkingDebtLabel;
        private System.Windows.Forms.Label actualParkingDebtStaticLabel;
    }
}

