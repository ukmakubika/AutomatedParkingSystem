namespace AutomatedTicketSystemProject_Group6
{
    partial class ManagerInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerInterface));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Reports = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbLongestHours = new System.Windows.Forms.RadioButton();
            this.rbLowToHigh = new System.Windows.Forms.RadioButton();
            this.rbHighToLow = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.listOutput = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.checkCustom = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtCustomName = new System.Windows.Forms.TextBox();
            this.cbGeneral = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HelpManager = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listCosts = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listAnswer = new System.Windows.Forms.ListBox();
            this.cbFAQ = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.Reports.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.HelpManager.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Reports);
            this.tabControl1.Controls.Add(this.HelpManager);
            this.tabControl1.Location = new System.Drawing.Point(24, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(740, 421);
            this.tabControl1.TabIndex = 0;
            // 
            // Reports
            // 
            this.Reports.Controls.Add(this.groupBox2);
            this.Reports.Controls.Add(this.listOutput);
            this.Reports.Controls.Add(this.groupBox1);
            this.Reports.Location = new System.Drawing.Point(4, 22);
            this.Reports.Name = "Reports";
            this.Reports.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Reports.Size = new System.Drawing.Size(732, 395);
            this.Reports.TabIndex = 0;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbLongestHours);
            this.groupBox2.Controls.Add(this.rbLowToHigh);
            this.groupBox2.Controls.Add(this.rbHighToLow);
            this.groupBox2.Controls.Add(this.rbName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(393, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 192);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordering";
            // 
            // rbLongestHours
            // 
            this.rbLongestHours.AutoSize = true;
            this.rbLongestHours.Enabled = false;
            this.rbLongestHours.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLongestHours.Location = new System.Drawing.Point(41, 142);
            this.rbLongestHours.Name = "rbLongestHours";
            this.rbLongestHours.Size = new System.Drawing.Size(104, 18);
            this.rbLongestHours.TabIndex = 12;
            this.rbLongestHours.TabStop = true;
            this.rbLongestHours.Text = "Longest Hours";
            this.rbLongestHours.UseVisualStyleBackColor = true;
            this.rbLongestHours.CheckedChanged += new System.EventHandler(this.rbLongestHours_CheckedChanged);
            // 
            // rbLowToHigh
            // 
            this.rbLowToHigh.AutoSize = true;
            this.rbLowToHigh.Enabled = false;
            this.rbLowToHigh.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLowToHigh.Location = new System.Drawing.Point(41, 112);
            this.rbLowToHigh.Name = "rbLowToHigh";
            this.rbLowToHigh.Size = new System.Drawing.Size(167, 18);
            this.rbLowToHigh.TabIndex = 11;
            this.rbLowToHigh.TabStop = true;
            this.rbLowToHigh.Text = "Total Visits (Low to High)";
            this.rbLowToHigh.UseVisualStyleBackColor = true;
            // 
            // rbHighToLow
            // 
            this.rbHighToLow.AutoSize = true;
            this.rbHighToLow.Enabled = false;
            this.rbHighToLow.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHighToLow.Location = new System.Drawing.Point(41, 82);
            this.rbHighToLow.Name = "rbHighToLow";
            this.rbHighToLow.Size = new System.Drawing.Size(167, 18);
            this.rbHighToLow.TabIndex = 10;
            this.rbHighToLow.TabStop = true;
            this.rbHighToLow.Text = "Total Visits (High to Low)";
            this.rbHighToLow.UseVisualStyleBackColor = true;
            this.rbHighToLow.CheckedChanged += new System.EventHandler(this.rbHighToLow_CheckedChanged);
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Enabled = false;
            this.rbName.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbName.Location = new System.Drawing.Point(41, 52);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(93, 18);
            this.rbName.TabIndex = 9;
            this.rbName.TabStop = true;
            this.rbName.Text = "Client Name";
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sort By";
            // 
            // listOutput
            // 
            this.listOutput.FormattingEnabled = true;
            this.listOutput.Items.AddRange(new object[] {
            "FNB/RMB",
            "ABSA BANK LIMITED",
            "Investec Bank"});
            this.listOutput.Location = new System.Drawing.Point(7, 216);
            this.listOutput.Name = "listOutput";
            this.listOutput.Size = new System.Drawing.Size(722, 173);
            this.listOutput.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.checkCustom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.txtCustomName);
            this.groupBox1.Controls.Add(this.cbGeneral);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 193);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Type";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(257, 46);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 26);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // checkCustom
            // 
            this.checkCustom.AutoSize = true;
            this.checkCustom.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCustom.Location = new System.Drawing.Point(28, 95);
            this.checkCustom.Name = "checkCustom";
            this.checkCustom.Size = new System.Drawing.Size(108, 18);
            this.checkCustom.TabIndex = 7;
            this.checkCustom.Text = "Custom Report";
            this.checkCustom.UseVisualStyleBackColor = true;
            this.checkCustom.CheckedChanged += new System.EventHandler(this.checkCustom_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Custom Report Name";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(257, 147);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(82, 26);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCustomName
            // 
            this.txtCustomName.Enabled = false;
            this.txtCustomName.Location = new System.Drawing.Point(28, 150);
            this.txtCustomName.Name = "txtCustomName";
            this.txtCustomName.Size = new System.Drawing.Size(174, 22);
            this.txtCustomName.TabIndex = 3;
            // 
            // cbGeneral
            // 
            this.cbGeneral.FormattingEnabled = true;
            this.cbGeneral.Items.AddRange(new object[] {
            "Top 3 Banks Used",
            "Longest Hours Spent"});
            this.cbGeneral.Location = new System.Drawing.Point(28, 46);
            this.cbGeneral.Name = "cbGeneral";
            this.cbGeneral.Size = new System.Drawing.Size(174, 22);
            this.cbGeneral.TabIndex = 1;
            this.cbGeneral.SelectedIndexChanged += new System.EventHandler(this.cbGeneral_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "General Reports";
            // 
            // HelpManager
            // 
            this.HelpManager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HelpManager.BackgroundImage")));
            this.HelpManager.Controls.Add(this.groupBox6);
            this.HelpManager.Controls.Add(this.groupBox5);
            this.HelpManager.Controls.Add(this.label11);
            this.HelpManager.Controls.Add(this.label12);
            this.HelpManager.Controls.Add(this.label13);
            this.HelpManager.Location = new System.Drawing.Point(4, 22);
            this.HelpManager.Name = "HelpManager";
            this.HelpManager.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.HelpManager.Size = new System.Drawing.Size(732, 395);
            this.HelpManager.TabIndex = 1;
            this.HelpManager.Text = "Help";
            this.HelpManager.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listCosts);
            this.groupBox6.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(429, 106);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(305, 263);
            this.groupBox6.TabIndex = 20;
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
            this.groupBox5.Location = new System.Drawing.Point(41, 111);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(353, 258);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Frequently Asked Questions";
            // 
            // listAnswer
            // 
            this.listAnswer.FormattingEnabled = true;
            this.listAnswer.ItemHeight = 14;
            this.listAnswer.Location = new System.Drawing.Point(17, 92);
            this.listAnswer.Name = "listAnswer";
            this.listAnswer.Size = new System.Drawing.Size(320, 88);
            this.listAnswer.TabIndex = 15;
            // 
            // cbFAQ
            // 
            this.cbFAQ.FormattingEnabled = true;
            this.cbFAQ.Items.AddRange(new object[] {
            "How can I see my top customers?",
            "What do I do if I forget my manager code?",
            "What do I do if I forget my Username?",
            "Can I use the app to request a mall code similarly to a customer?"});
            this.cbFAQ.Location = new System.Drawing.Point(78, 52);
            this.cbFAQ.Name = "cbFAQ";
            this.cbFAQ.Size = new System.Drawing.Size(202, 22);
            this.cbFAQ.TabIndex = 14;
            this.cbFAQ.SelectedIndexChanged += new System.EventHandler(this.cbFAQ_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(196, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(374, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "AUTOMATED PARKING SYSTEM";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(214, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(319, 14);
            this.label12.TabIndex = 17;
            this.label12.Text = "Please select one of the frequently asked questions below.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(189, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(408, 14);
            this.label13.TabIndex = 16;
            this.label13.Text = "Whether you’re a manager or customer, we’re here to offer a helping hand. ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 24);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(780, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(372, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Manager Interface";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 465);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(780, 24);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 465);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(21, 465);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(759, 24);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(737, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ManagerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerInterface";
            this.Text = "ManagerInterface";
            this.tabControl1.ResumeLayout(false);
            this.Reports.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.HelpManager.ResumeLayout(false);
            this.HelpManager.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Reports;
        private System.Windows.Forms.TabPage HelpManager;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbFAQ;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listAnswer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtCustomName;
        private System.Windows.Forms.ComboBox cbGeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbLongestHours;
        private System.Windows.Forms.RadioButton rbLowToHigh;
        private System.Windows.Forms.RadioButton rbHighToLow;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listOutput;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox checkCustom;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox listCosts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}