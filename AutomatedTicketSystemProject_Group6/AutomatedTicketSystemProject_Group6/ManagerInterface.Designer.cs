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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Reports = new System.Windows.Forms.TabPage();
            this.HelpManager = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listAnswer = new System.Windows.Forms.ListBox();
            this.cbFAQ = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.HelpManager.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Reports);
            this.tabControl1.Controls.Add(this.HelpManager);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1305, 630);
            this.tabControl1.TabIndex = 0;
            // 
            // Reports
            // 
            this.Reports.BackgroundImage = global::AutomatedTicketSystemProject_Group6.Properties.Resources.pexels_pixabay_257416;
            this.Reports.Location = new System.Drawing.Point(4, 25);
            this.Reports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reports.Name = "Reports";
            this.Reports.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reports.Size = new System.Drawing.Size(1297, 601);
            this.Reports.TabIndex = 0;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            // 
            // HelpManager
            // 
            this.HelpManager.BackgroundImage = global::AutomatedTicketSystemProject_Group6.Properties.Resources.pexels_pixabay_257416;
            this.HelpManager.Controls.Add(this.groupBox5);
            this.HelpManager.Controls.Add(this.label11);
            this.HelpManager.Controls.Add(this.label12);
            this.HelpManager.Controls.Add(this.label13);
            this.HelpManager.Location = new System.Drawing.Point(4, 25);
            this.HelpManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HelpManager.Name = "HelpManager";
            this.HelpManager.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HelpManager.Size = new System.Drawing.Size(1297, 601);
            this.HelpManager.TabIndex = 1;
            this.HelpManager.Text = "Help";
            this.HelpManager.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbFAQ);
            this.groupBox5.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(288, 158);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(471, 164);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Frequently Asked Quetsions";
            // 
            // listAnswer
            // 
            this.listAnswer.FormattingEnabled = true;
            this.listAnswer.Location = new System.Drawing.Point(17, 92);
            this.listAnswer.Name = "listAnswer";
            this.listAnswer.Size = new System.Drawing.Size(320, 95);
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
            this.cbFAQ.Location = new System.Drawing.Point(101, 69);
            this.cbFAQ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFAQ.Name = "cbFAQ";
            this.cbFAQ.Size = new System.Drawing.Size(268, 26);
            this.cbFAQ.TabIndex = 14;
            this.cbFAQ.SelectedIndexChanged += new System.EventHandler(this.cbFAQ_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(383, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(475, 31);
            this.label11.TabIndex = 18;
            this.label11.Text = "AUTOMATED PARKING SYSTEM";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(385, 110);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(419, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "Please select one of the frequently asked questions below.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(352, 86);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(542, 18);
            this.label13.TabIndex = 16;
            this.label13.Text = "Whether you’re a manager or customer, we’re here to offer a helping hand. ";
            // 
            // ManagerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutomatedTicketSystemProject_Group6.Properties.Resources.pexels_brett_sayles_1756957;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1334, 658);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ManagerInterface";
            this.Text = "ManagerInterface";
            this.Load += new System.EventHandler(this.ManagerInterface_Load);
            this.tabControl1.ResumeLayout(false);
            this.HelpManager.ResumeLayout(false);
            this.HelpManager.PerformLayout();
            this.groupBox5.ResumeLayout(false);
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
    }
}