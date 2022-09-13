namespace AutomatedTicketSystemProject_Group6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInterface));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.timeSeconds = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.timeMinutes = new System.Windows.Forms.Label();
            this.timeHours = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
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
            this.label2 = new System.Windows.Forms.Label();
            this.PaymentDetails = new System.Windows.Forms.TabPage();
            this.txtDisplay = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dbBankAccounts = new System.Windows.Forms.DataGridView();
            this.EditProfile = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.listDetail = new System.Windows.Forms.ListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbUpdate = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tbnUpdate = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Help = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listCosts = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listAnswer = new System.Windows.Forms.ListBox();
            this.cbFAQ = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.timeTracker = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.MainPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PaymentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbBankAccounts)).BeginInit();
            this.EditProfile.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.Help.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MainPage);
            this.tabControl1.Controls.Add(this.PaymentDetails);
            this.tabControl1.Controls.Add(this.EditProfile);
            this.tabControl1.Controls.Add(this.Help);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // MainPage
            // 
            this.MainPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPage.BackgroundImage")));
            this.MainPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPage.Controls.Add(this.button1);
            this.MainPage.Controls.Add(this.groupBox3);
            this.MainPage.Controls.Add(this.label14);
            this.MainPage.Controls.Add(this.groupBox4);
            this.MainPage.Controls.Add(this.groupBox2);
            this.MainPage.Controls.Add(this.groupBox1);
            this.MainPage.Controls.Add(this.label2);
            this.MainPage.Location = new System.Drawing.Point(4, 22);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(767, 399);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "Main Page";
            this.MainPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox10);
            this.groupBox3.Controls.Add(this.btnPay);
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(314, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 277);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Timer";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label21);
            this.groupBox10.Controls.Add(this.timeSeconds);
            this.groupBox10.Controls.Add(this.label20);
            this.groupBox10.Controls.Add(this.timeMinutes);
            this.groupBox10.Controls.Add(this.timeHours);
            this.groupBox10.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(21, 169);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(140, 63);
            this.groupBox10.TabIndex = 25;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Time Elapsed";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(77, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(11, 14);
            this.label21.TabIndex = 25;
            this.label21.Text = ":";
            // 
            // timeSeconds
            // 
            this.timeSeconds.AutoSize = true;
            this.timeSeconds.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSeconds.Location = new System.Drawing.Point(86, 25);
            this.timeSeconds.Name = "timeSeconds";
            this.timeSeconds.Size = new System.Drawing.Size(21, 14);
            this.timeSeconds.TabIndex = 22;
            this.timeSeconds.Text = "00";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(48, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(11, 14);
            this.label20.TabIndex = 24;
            this.label20.Text = ":";
            // 
            // timeMinutes
            // 
            this.timeMinutes.AutoSize = true;
            this.timeMinutes.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeMinutes.Location = new System.Drawing.Point(54, 25);
            this.timeMinutes.Name = "timeMinutes";
            this.timeMinutes.Size = new System.Drawing.Size(21, 14);
            this.timeMinutes.TabIndex = 21;
            this.timeMinutes.Text = "00";
            // 
            // timeHours
            // 
            this.timeHours.AutoSize = true;
            this.timeHours.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeHours.Location = new System.Drawing.Point(26, 25);
            this.timeHours.Name = "timeHours";
            this.timeHours.Size = new System.Drawing.Size(21, 14);
            this.timeHours.TabIndex = 20;
            this.timeHours.Text = "00";
            // 
            // btnPay
            // 
            this.btnPay.Enabled = false;
            this.btnPay.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(37, 112);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(108, 36);
            this.btnPay.TabIndex = 24;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click_1);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(37, 70);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(108, 36);
            this.btnStop.TabIndex = 18;
            this.btnStop.Text = "Stop Time";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(37, 28);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 36);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start Time";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(224, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(374, 25);
            this.label14.TabIndex = 17;
            this.label14.Text = "AUTOMATED PARKING SYSTEM";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.listCode);
            this.groupBox4.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(22, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(261, 124);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Code Display";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 14);
            this.label10.TabIndex = 15;
            this.label10.Text = "Here is your code...";
            // 
            // listCode
            // 
            this.listCode.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCode.FormattingEnabled = true;
            this.listCode.ItemHeight = 14;
            this.listCode.Location = new System.Drawing.Point(36, 58);
            this.listCode.Name = "listCode";
            this.listCode.Size = new System.Drawing.Size(161, 18);
            this.listCode.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listPrev);
            this.groupBox2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(519, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 278);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Previous Vistis";
            // 
            // listPrev
            // 
            this.listPrev.FormattingEnabled = true;
            this.listPrev.ItemHeight = 14;
            this.listPrev.Location = new System.Drawing.Point(21, 30);
            this.listPrev.Name = "listPrev";
            this.listPrev.Size = new System.Drawing.Size(188, 214);
            this.listPrev.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRequest);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 135);
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
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Will you be visiting the mall today?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Welcome Back";
            // 
            // PaymentDetails
            // 
            this.PaymentDetails.BackgroundImage = global::AutomatedTicketSystemProject_Group6.Properties.Resources.pexels_monstera_7794440__1_;
            this.PaymentDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaymentDetails.Controls.Add(this.txtDisplay);
            this.PaymentDetails.Controls.Add(this.label6);
            this.PaymentDetails.Controls.Add(this.txtDelete);
            this.PaymentDetails.Controls.Add(this.label4);
            this.PaymentDetails.Controls.Add(this.txtSearch);
            this.PaymentDetails.Controls.Add(this.label1);
            this.PaymentDetails.Controls.Add(this.btnDelete);
            this.PaymentDetails.Controls.Add(this.btnAdd);
            this.PaymentDetails.Controls.Add(this.dbBankAccounts);
            this.PaymentDetails.Location = new System.Drawing.Point(4, 22);
            this.PaymentDetails.Name = "PaymentDetails";
            this.PaymentDetails.Padding = new System.Windows.Forms.Padding(3);
            this.PaymentDetails.Size = new System.Drawing.Size(767, 399);
            this.PaymentDetails.TabIndex = 1;
            this.PaymentDetails.Text = "Payment Details";
            this.PaymentDetails.UseVisualStyleBackColor = true;
            this.PaymentDetails.Click += new System.EventHandler(this.PaymentDetails_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(34, 153);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(104, 36);
            this.txtDisplay.TabIndex = 9;
            this.txtDisplay.Text = "Show All";
            this.txtDisplay.UseVisualStyleBackColor = true;
            this.txtDisplay.Click += new System.EventHandler(this.txtDisplay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Card to Delete";
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(33, 349);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(205, 20);
            this.txtDelete.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "What would you like to do today?";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(35, 108);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 20);
            this.txtSearch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(33, 276);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(35, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dbBankAccounts
            // 
            this.dbBankAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbBankAccounts.Location = new System.Drawing.Point(299, 89);
            this.dbBankAccounts.Name = "dbBankAccounts";
            this.dbBankAccounts.Size = new System.Drawing.Size(434, 280);
            this.dbBankAccounts.TabIndex = 0;
            // 
            // EditProfile
            // 
            this.EditProfile.BackgroundImage = global::AutomatedTicketSystemProject_Group6.Properties.Resources.pexels_monstera_7794440__1_;
            this.EditProfile.Controls.Add(this.groupBox9);
            this.EditProfile.Controls.Add(this.groupBox8);
            this.EditProfile.Controls.Add(this.groupBox7);
            this.EditProfile.Location = new System.Drawing.Point(4, 22);
            this.EditProfile.Name = "EditProfile";
            this.EditProfile.Size = new System.Drawing.Size(767, 399);
            this.EditProfile.TabIndex = 3;
            this.EditProfile.Text = "Edit Profile";
            this.EditProfile.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.listDetail);
            this.groupBox9.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(397, 34);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(347, 141);
            this.groupBox9.TabIndex = 73;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Saved Detail";
            // 
            // listDetail
            // 
            this.listDetail.FormattingEnabled = true;
            this.listDetail.ItemHeight = 14;
            this.listDetail.Location = new System.Drawing.Point(69, 63);
            this.listDetail.Name = "listDetail";
            this.listDetail.Size = new System.Drawing.Size(215, 18);
            this.listDetail.TabIndex = 72;
            this.listDetail.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.cbUpdate);
            this.groupBox8.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(15, 34);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(360, 141);
            this.groupBox8.TabIndex = 71;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Selection";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 14);
            this.label8.TabIndex = 70;
            this.label8.Text = "What detail would you like to update?";
            // 
            // cbUpdate
            // 
            this.cbUpdate.FormattingEnabled = true;
            this.cbUpdate.Items.AddRange(new object[] {
            "Surname",
            "Email Address",
            "Username ",
            "Contact Number"});
            this.cbUpdate.Location = new System.Drawing.Point(26, 72);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(215, 22);
            this.cbUpdate.TabIndex = 69;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tbnUpdate);
            this.groupBox7.Controls.Add(this.txtUsername);
            this.groupBox7.Controls.Add(this.txtEmail);
            this.groupBox7.Controls.Add(this.txtContact);
            this.groupBox7.Controls.Add(this.txtSurname);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(15, 202);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(729, 175);
            this.groupBox7.TabIndex = 45;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Personal Details";
            // 
            // tbnUpdate
            // 
            this.tbnUpdate.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnUpdate.Location = new System.Drawing.Point(26, 122);
            this.tbnUpdate.Name = "tbnUpdate";
            this.tbnUpdate.Size = new System.Drawing.Size(95, 28);
            this.tbnUpdate.TabIndex = 69;
            this.tbnUpdate.Text = "Update";
            this.tbnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(492, 35);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(215, 22);
            this.txtUsername.TabIndex = 68;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(136, 77);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(215, 22);
            this.txtEmail.TabIndex = 67;
            // 
            // txtContact
            // 
            this.txtContact.Enabled = false;
            this.txtContact.Location = new System.Drawing.Point(492, 80);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(215, 22);
            this.txtContact.TabIndex = 65;
            // 
            // txtSurname
            // 
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(136, 38);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(215, 22);
            this.txtSurname.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(379, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 14);
            this.label7.TabIndex = 9;
            this.label7.Text = "Username:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "Email Address:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(379, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 14);
            this.label15.TabIndex = 6;
            this.label15.Text = "Contact Number:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 14);
            this.label16.TabIndex = 1;
            this.label16.Text = "Surname:";
            // 
            // Help
            // 
            this.Help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Help.BackgroundImage")));
            this.Help.Controls.Add(this.groupBox6);
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listCosts);
            this.groupBox6.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(423, 118);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(305, 263);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Parking Fees";
            // 
            // listCosts
            // 
            this.listCosts.FormattingEnabled = true;
            this.listCosts.ItemHeight = 14;
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
            this.groupBox5.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(39, 118);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(353, 263);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Frequently Asked Quetsions";
            // 
            // listAnswer
            // 
            this.listAnswer.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAnswer.FormattingEnabled = true;
            this.listAnswer.ItemHeight = 14;
            this.listAnswer.Location = new System.Drawing.Point(17, 103);
            this.listAnswer.Name = "listAnswer";
            this.listAnswer.Size = new System.Drawing.Size(321, 130);
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
            this.cbFAQ.Size = new System.Drawing.Size(202, 22);
            this.cbFAQ.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(188, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(374, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "AUTOMATED PARKING SYSTEM";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(203, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(319, 14);
            this.label12.TabIndex = 12;
            this.label12.Text = "Please select one of the frequently asked questions below.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(178, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(408, 14);
            this.label13.TabIndex = 11;
            this.label13.Text = "Whether you’re a manager or customer, we’re here to offer a helping hand. ";
            // 
            // timeTracker
            // 
            this.timeTracker.Enabled = true;
            this.timeTracker.Interval = 1000;
            this.timeTracker.Tick += new System.EventHandler(this.timeTracker_Tick_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(671, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 29);
            this.button1.TabIndex = 20;
            this.button1.Text = "Sign out";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CustomerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutomatedTicketSystemProject_Group6.Properties.Resources.pexels_brett_sayles_1756957__2_;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerInterface";
            this.Text = "Customer Interface";
            this.Load += new System.EventHandler(this.CustomerInterface_Load);
            this.tabControl1.ResumeLayout(false);
            this.MainPage.ResumeLayout(false);
            this.MainPage.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PaymentDetails.ResumeLayout(false);
            this.PaymentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbBankAccounts)).EndInit();
            this.EditProfile.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.Help.ResumeLayout(false);
            this.Help.PerformLayout();
            this.groupBox6.ResumeLayout(false);
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
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.ListBox listAnswer;
        private System.Windows.Forms.DataGridView dbBankAccounts;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Button txtDisplay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timeTracker;
        private System.Windows.Forms.ListBox listCosts;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TabPage EditProfile;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ListBox listDetail;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbUpdate;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button tbnUpdate;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label timeSeconds;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label timeMinutes;
        private System.Windows.Forms.Label timeHours;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button button1;
    }
}