﻿namespace AutomatedTicketSystemProject_Group6
{
    partial class CustomerInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInterface));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listCode = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listPrev = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PaymentDetails = new System.Windows.Forms.TabPage();
            this.txtDisplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dbBankAccounts = new System.Windows.Forms.DataGridView();
            this.Help = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listCosts = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listAnswer = new System.Windows.Forms.ListBox();
            this.cbFAQ = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.EditProfile = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.MainPage.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PaymentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbBankAccounts)).BeginInit();
            this.Help.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MainPage);
            this.tabControl1.Controls.Add(this.PaymentDetails);
            this.tabControl1.Controls.Add(this.EditProfile);
            this.tabControl1.Controls.Add(this.Help);
            this.tabControl1.Location = new System.Drawing.Point(26, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(749, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // MainPage
            // 
            this.MainPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPage.BackgroundImage")));
            this.MainPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPage.Controls.Add(this.groupBox6);
            this.MainPage.Controls.Add(this.label14);
            this.MainPage.Controls.Add(this.groupBox4);
            this.MainPage.Controls.Add(this.groupBox2);
            this.MainPage.Controls.Add(this.groupBox1);
            this.MainPage.Controls.Add(this.label5);
            this.MainPage.Controls.Add(this.label2);
            this.MainPage.Location = new System.Drawing.Point(4, 22);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(741, 399);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "Main Page";
            this.MainPage.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnStop);
            this.groupBox6.Controls.Add(this.btnStart);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(296, 101);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(181, 277);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Timer";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(37, 84);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(108, 36);
            this.btnStop.TabIndex = 18;
            this.btnStop.Text = "Stop Time";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(37, 28);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 36);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start Time";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(207, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(374, 25);
            this.label14.TabIndex = 17;
            this.label14.Text = "AUTOMATED PARKING SYSTEM";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.listCode);
            this.groupBox4.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(20, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 124);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Code Display";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Here is your code...";
            // 
            // listCode
            // 
            this.listCode.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCode.FormattingEnabled = true;
            this.listCode.ItemHeight = 15;
            this.listCode.Location = new System.Drawing.Point(36, 58);
            this.listCode.Name = "listCode";
            this.listCode.Size = new System.Drawing.Size(169, 19);
            this.listCode.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listPrev);
            this.groupBox2.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(483, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 278);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Previous Vistis";
            // 
            // listPrev
            // 
            this.listPrev.FormattingEnabled = true;
            this.listPrev.ItemHeight = 15;
            this.listPrev.Location = new System.Drawing.Point(23, 32);
            this.listPrev.Name = "listPrev";
            this.listPrev.Size = new System.Drawing.Size(188, 199);
            this.listPrev.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRequest);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 135);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request Code";
            // 
            // btnRequest
            // 
            this.btnRequest.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Location = new System.Drawing.Point(36, 65);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(108, 36);
            this.btnRequest.TabIndex = 4;
            this.btnRequest.Text = "Request Code";
            this.btnRequest.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Will you be visiting the mall today?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Welcome Back";
            // 
            // PaymentDetails
            // 
            this.PaymentDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PaymentDetails.BackgroundImage")));
            this.PaymentDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaymentDetails.Controls.Add(this.txtDisplay);
            this.PaymentDetails.Controls.Add(this.label1);
            this.PaymentDetails.Controls.Add(this.txtDelete);
            this.PaymentDetails.Controls.Add(this.lblName);
            this.PaymentDetails.Controls.Add(this.label4);
            this.PaymentDetails.Controls.Add(this.txtSearch);
            this.PaymentDetails.Controls.Add(this.label7);
            this.PaymentDetails.Controls.Add(this.btnDelete);
            this.PaymentDetails.Controls.Add(this.btnAdd);
            this.PaymentDetails.Controls.Add(this.dbBankAccounts);
            this.PaymentDetails.Location = new System.Drawing.Point(4, 22);
            this.PaymentDetails.Name = "PaymentDetails";
            this.PaymentDetails.Padding = new System.Windows.Forms.Padding(3);
            this.PaymentDetails.Size = new System.Drawing.Size(741, 399);
            this.PaymentDetails.TabIndex = 1;
            this.PaymentDetails.Text = "Payment Details";
            this.PaymentDetails.UseVisualStyleBackColor = true;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(23, 152);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(104, 36);
            this.txtDisplay.TabIndex = 19;
            this.txtDisplay.Text = "Show All";
            this.txtDisplay.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Card to Delete";
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(22, 348);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(205, 20);
            this.txtDelete.TabIndex = 17;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(326, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 24);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "What would you like to do today,";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(24, 107);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 20);
            this.txtSearch.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Search";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(22, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 36);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 211);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 36);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dbBankAccounts
            // 
            this.dbBankAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbBankAccounts.Location = new System.Drawing.Point(288, 88);
            this.dbBankAccounts.Name = "dbBankAccounts";
            this.dbBankAccounts.Size = new System.Drawing.Size(434, 280);
            this.dbBankAccounts.TabIndex = 10;
            // 
            // Help
            // 
            this.Help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Help.BackgroundImage")));
            this.Help.Controls.Add(this.groupBox3);
            this.Help.Controls.Add(this.groupBox5);
            this.Help.Controls.Add(this.label11);
            this.Help.Controls.Add(this.label12);
            this.Help.Controls.Add(this.label13);
            this.Help.Location = new System.Drawing.Point(4, 22);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(741, 399);
            this.Help.TabIndex = 2;
            this.Help.Text = "Help ";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 465);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 24);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 25);
            this.panel2.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(728, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(333, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 15);
            this.label6.TabIndex = 49;
            this.label6.Text = "Customer Interface";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(780, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 440);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(780, 25);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 440);
            this.panel4.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listCosts);
            this.groupBox3.Location = new System.Drawing.Point(410, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 263);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parking Fees";
            // 
            // listCosts
            // 
            this.listCosts.FormattingEnabled = true;
            this.listCosts.Items.AddRange(new object[] {
            "0 - 1 hours\t R5",
            "",
            "1-2 hours\t \tR10",
            "",
            "2-3 hours\t \tR10",
            "",
            "3-4 hours\t \tR10",
            "",
            "4-5 hours\t \tR10",
            "",
            "5-6 hours\t \tR10",
            "",
            "6+ hours\t \tR40"});
            this.listCosts.Location = new System.Drawing.Point(44, 38);
            this.listCosts.Name = "listCosts";
            this.listCosts.Size = new System.Drawing.Size(214, 186);
            this.listCosts.TabIndex = 16;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listAnswer);
            this.groupBox5.Controls.Add(this.cbFAQ);
            this.groupBox5.Location = new System.Drawing.Point(26, 118);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(353, 263);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Frequently Asked Quetsions";
            // 
            // listAnswer
            // 
            this.listAnswer.FormattingEnabled = true;
            this.listAnswer.Location = new System.Drawing.Point(17, 103);
            this.listAnswer.Name = "listAnswer";
            this.listAnswer.Size = new System.Drawing.Size(321, 134);
            this.listAnswer.TabIndex = 15;
            // 
            // cbFAQ
            // 
            this.cbFAQ.FormattingEnabled = true;
            this.cbFAQ.Items.AddRange(new object[] {
            "Where can I get my Requested Code code?",
            "Which bank cards are accepted on the Automated Parking System?",
            "Is there a fee to use the Automated Parking System app?",
            "How do I add/remove a bank card on the Automated Parking System app?",
            "How do I set default card on the Automated Parking System app?",
            "What if I forget my password?"});
            this.cbFAQ.Location = new System.Drawing.Point(76, 56);
            this.cbFAQ.Name = "cbFAQ";
            this.cbFAQ.Size = new System.Drawing.Size(202, 21);
            this.cbFAQ.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(204, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(337, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "AUTOMATED PARKING SYSTEM";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(190, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(355, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Please select one of the frequently asked questions below.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(165, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(446, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "Whether you’re a manager or customer, we’re here to offer a helping hand. ";
            // 
            // EditProfile
            // 
            this.EditProfile.Location = new System.Drawing.Point(4, 22);
            this.EditProfile.Name = "EditProfile";
            this.EditProfile.Size = new System.Drawing.Size(741, 399);
            this.EditProfile.TabIndex = 3;
            this.EditProfile.Text = "Edit Profile";
            this.EditProfile.UseVisualStyleBackColor = true;
            // 
            // CustomerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerInterface";
            this.Text = "Functions";
            this.tabControl1.ResumeLayout(false);
            this.MainPage.ResumeLayout(false);
            this.MainPage.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PaymentDetails.ResumeLayout(false);
            this.PaymentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbBankAccounts)).EndInit();
            this.Help.ResumeLayout(false);
            this.Help.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MainPage;
        private System.Windows.Forms.TabPage PaymentDetails;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listPrev;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listCode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabPage Help;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button txtDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dbBankAccounts;
        private System.Windows.Forms.TabPage EditProfile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listCosts;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listAnswer;
        private System.Windows.Forms.ComboBox cbFAQ;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}