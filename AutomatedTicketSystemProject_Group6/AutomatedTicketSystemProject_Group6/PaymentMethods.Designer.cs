namespace AutomatedTicketSystemProject_Group6
{
    partial class PaymentMethods
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBankNames = new System.Windows.Forms.ComboBox();
            this.expCal = new System.Windows.Forms.MonthCalendar();
            this.txtBranchNo = new System.Windows.Forms.TextBox();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.pbBank = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBank)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expiration Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Card Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Branch Number:";
            // 
            // cbBankNames
            // 
            this.cbBankNames.FormattingEnabled = true;
            this.cbBankNames.Location = new System.Drawing.Point(141, 36);
            this.cbBankNames.Name = "cbBankNames";
            this.cbBankNames.Size = new System.Drawing.Size(227, 21);
            this.cbBankNames.TabIndex = 5;
            // 
            // expCal
            // 
            this.expCal.Location = new System.Drawing.Point(141, 255);
            this.expCal.Name = "expCal";
            this.expCal.TabIndex = 6;
            // 
            // txtBranchNo
            // 
            this.txtBranchNo.Location = new System.Drawing.Point(141, 85);
            this.txtBranchNo.Name = "txtBranchNo";
            this.txtBranchNo.Size = new System.Drawing.Size(227, 20);
            this.txtBranchNo.TabIndex = 7;
            this.txtBranchNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(141, 138);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(227, 20);
            this.txtCardNo.TabIndex = 8;
            // 
            // pbBank
            // 
            this.pbBank.Location = new System.Drawing.Point(416, 36);
            this.pbBank.Name = "pbBank";
            this.pbBank.Size = new System.Drawing.Size(124, 54);
            this.pbBank.TabIndex = 9;
            this.pbBank.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(38, 445);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 37);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "CVV:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 12;
            // 
            // PaymentMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 506);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbBank);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.txtBranchNo);
            this.Controls.Add(this.expCal);
            this.Controls.Add(this.cbBankNames);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "PaymentMethods";
            this.Text = "PaymentMethods";
            ((System.ComponentModel.ISupportInitialize)(this.pbBank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBankNames;
        private System.Windows.Forms.MonthCalendar expCal;
        private System.Windows.Forms.TextBox txtBranchNo;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.PictureBox pbBank;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}