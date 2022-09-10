namespace AutomatedTicketSystemProject_Group6
{
    partial class Functions
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.cbBankNames = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listAnswer = new System.Windows.Forms.ListBox();
            this.cbFAQ = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.errBankname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCardNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCVV = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMonth = new System.Windows.Forms.ErrorProvider(this.components);
            this.errYear = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.MainPage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PaymentDetails.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Help.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errBankname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCardNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCVV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errYear)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MainPage);
            this.tabControl1.Controls.Add(this.PaymentDetails);
            this.tabControl1.Controls.Add(this.Help);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // MainPage
            // 
            this.MainPage.Controls.Add(this.label14);
            this.MainPage.Controls.Add(this.groupBox4);
            this.MainPage.Controls.Add(this.groupBox2);
            this.MainPage.Controls.Add(this.groupBox1);
            this.MainPage.Controls.Add(this.label5);
            this.MainPage.Controls.Add(this.label2);
            this.MainPage.Location = new System.Drawing.Point(4, 22);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(767, 399);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "Main Page";
            this.MainPage.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(207, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(337, 25);
            this.label14.TabIndex = 17;
            this.label14.Text = "AUTOMATED PARKING SYSTEM";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.listCode);
            this.groupBox4.Location = new System.Drawing.Point(102, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 124);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Code Display";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Here is your code...";
            // 
            // listCode
            // 
            this.listCode.FormattingEnabled = true;
            this.listCode.Location = new System.Drawing.Point(36, 58);
            this.listCode.Name = "listCode";
            this.listCode.Size = new System.Drawing.Size(235, 30);
            this.listCode.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listPrev);
            this.groupBox2.Location = new System.Drawing.Point(450, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 278);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Previous Vistis";
            // 
            // listPrev
            // 
            this.listPrev.FormattingEnabled = true;
            this.listPrev.Location = new System.Drawing.Point(41, 40);
            this.listPrev.Name = "listPrev";
            this.listPrev.Size = new System.Drawing.Size(188, 212);
            this.listPrev.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRequest);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(102, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 135);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request Code";
            // 
            // btnRequest
            // 
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Will you be visiting the mall today?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Welcome Back";
            // 
            // PaymentDetails
            // 
            this.PaymentDetails.Controls.Add(this.groupBox3);
            this.PaymentDetails.Controls.Add(this.btnSave);
            this.PaymentDetails.Location = new System.Drawing.Point(4, 22);
            this.PaymentDetails.Name = "PaymentDetails";
            this.PaymentDetails.Padding = new System.Windows.Forms.Padding(3);
            this.PaymentDetails.Size = new System.Drawing.Size(767, 399);
            this.PaymentDetails.TabIndex = 1;
            this.PaymentDetails.Text = "Payment Details";
            this.PaymentDetails.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbYear);
            this.groupBox3.Controls.Add(this.cbMonth);
            this.groupBox3.Controls.Add(this.txtCVV);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtCardNo);
            this.groupBox3.Controls.Add(this.cbBankNames);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(33, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 376);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bank Details";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(138, 318);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 16);
            this.label15.TabIndex = 28;
            this.label15.Text = "Year:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Month:";
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032"});
            this.cbYear.Location = new System.Drawing.Point(202, 313);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(161, 21);
            this.cbYear.TabIndex = 26;
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbMonth.Location = new System.Drawing.Point(203, 258);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(161, 21);
            this.cbMonth.TabIndex = 25;
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(137, 191);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(227, 20);
            this.txtCVV.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "CVV:";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(137, 123);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(227, 20);
            this.txtCardNo.TabIndex = 20;
            // 
            // cbBankNames
            // 
            this.cbBankNames.FormattingEnabled = true;
            this.cbBankNames.Items.AddRange(new object[] {
            "FNB/RMB",
            "ABSA BANK LIMITED",
            "Capitec Bank",
            "Nedbank Limited",
            "Standard Bank",
            "African Bank",
            "Albaraka Bank",
            "BNP Paribas",
            "Bidvest Bank",
            "CitiBank",
            "Access Bank (South Africa) Ltd",
            "Bank Zero ",
            "Discovery Bank",
            "FinBond Mutual Bank",
            "Finbond Net1",
            "Grindrob Bank",
            "HBZ Bank",
            "HSBC Bank",
            "Habib Overseas Bank",
            "Investec Bank",
            "Ithala",
            "JP Morgan Chase",
            "MTN Banking",
            "Mercantile Bank",
            "Nedbank Incorp FCB",
            "Nedbank PEP Bank",
            "Olympus mODILE",
            "People\'s Bank Ltd Inc NBS",
            "S.A. Reserve Bank",
            "SASFIN Bank",
            "Societe Generale",
            "South African Postbank SOC Ltd",
            "Standard Chartered Bank",
            "State Bank of India",
            "TymeBank",
            "UBank Limited",
            "Unibank",
            "VBS Mutual Bank"});
            this.cbBankNames.Location = new System.Drawing.Point(137, 58);
            this.cbBankNames.Name = "cbBankNames";
            this.cbBankNames.Size = new System.Drawing.Size(227, 21);
            this.cbBankNames.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Card Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Expiration Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Bank Name:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(654, 346);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 37);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Help
            // 
            this.Help.Controls.Add(this.groupBox5);
            this.Help.Controls.Add(this.label11);
            this.Help.Controls.Add(this.label12);
            this.Help.Controls.Add(this.label13);
            this.Help.Location = new System.Drawing.Point(4, 22);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(767, 399);
            this.Help.TabIndex = 2;
            this.Help.Text = "Help ";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listAnswer);
            this.groupBox5.Controls.Add(this.cbFAQ);
            this.groupBox5.Location = new System.Drawing.Point(205, 130);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(353, 210);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Frequently Asked Quetsions";
            // 
            // listAnswer
            // 
            this.listAnswer.FormattingEnabled = true;
            this.listAnswer.Location = new System.Drawing.Point(17, 96);
            this.listAnswer.Name = "listAnswer";
            this.listAnswer.Size = new System.Drawing.Size(320, 95);
            this.listAnswer.TabIndex = 16;
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
            this.cbFAQ.SelectedIndexChanged += new System.EventHandler(this.cbFAQ_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(217, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(337, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "AUTOMATED PARKING SYSTEM";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(203, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(355, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Please select one of the frequently asked questions below.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(178, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(446, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "Whether you’re a manager or customer, we’re here to offer a helping hand. ";
            // 
            // errBankname
            // 
            this.errBankname.ContainerControl = this;
            // 
            // errCardNo
            // 
            this.errCardNo.ContainerControl = this;
            // 
            // errCVV
            // 
            this.errCVV.ContainerControl = this;
            // 
            // errMonth
            // 
            this.errMonth.ContainerControl = this;
            // 
            // errYear
            // 
            this.errYear.ContainerControl = this;
            // 
            // Functions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.tabControl1);
            this.Name = "Functions";
            this.Text = "Functions";
            this.tabControl1.ResumeLayout(false);
            this.MainPage.ResumeLayout(false);
            this.MainPage.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PaymentDetails.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Help.ResumeLayout(false);
            this.Help.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errBankname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCardNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCVV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errYear)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.ComboBox cbBankNames;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listCode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabPage Help;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbFAQ;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ListBox listAnswer;
        private System.Windows.Forms.ErrorProvider errBankname;
        private System.Windows.Forms.ErrorProvider errCardNo;
        private System.Windows.Forms.ErrorProvider errCVV;
        private System.Windows.Forms.ErrorProvider errMonth;
        private System.Windows.Forms.ErrorProvider errYear;
    }
}