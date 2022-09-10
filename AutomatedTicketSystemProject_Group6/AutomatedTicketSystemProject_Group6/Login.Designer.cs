namespace AutomatedTicketSystemProject_Group6
{
    partial class MainLogin
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
            this.pbManager = new System.Windows.Forms.PictureBox();
            this.pbClient = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.linkPassword = new System.Windows.Forms.LinkLabel();
            this.linkSignup = new System.Windows.Forms.LinkLabel();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.rbClient = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClient)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbManager
            // 
            this.pbManager.Location = new System.Drawing.Point(56, 47);
            this.pbManager.Name = "pbManager";
            this.pbManager.Size = new System.Drawing.Size(268, 188);
            this.pbManager.TabIndex = 0;
            this.pbManager.TabStop = false;
            // 
            // pbClient
            // 
            this.pbClient.Location = new System.Drawing.Point(476, 47);
            this.pbClient.Name = "pbClient";
            this.pbClient.Size = new System.Drawing.Size(268, 188);
            this.pbClient.TabIndex = 1;
            this.pbClient.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            this.label2.UseWaitCursor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(56, 448);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 34);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtUsername.Location = new System.Drawing.Point(108, 36);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(292, 20);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.UseWaitCursor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtPassword.Location = new System.Drawing.Point(108, 72);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(292, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseWaitCursor = true;
            // 
            // linkPassword
            // 
            this.linkPassword.AutoSize = true;
            this.linkPassword.Location = new System.Drawing.Point(417, 79);
            this.linkPassword.Name = "linkPassword";
            this.linkPassword.Size = new System.Drawing.Size(92, 13);
            this.linkPassword.TabIndex = 7;
            this.linkPassword.TabStop = true;
            this.linkPassword.Text = "Forgot Password?";
            this.linkPassword.UseWaitCursor = true;
            // 
            // linkSignup
            // 
            this.linkSignup.AutoSize = true;
            this.linkSignup.Location = new System.Drawing.Point(417, 43);
            this.linkSignup.Name = "linkSignup";
            this.linkSignup.Size = new System.Drawing.Size(111, 13);
            this.linkSignup.TabIndex = 8;
            this.linkSignup.TabStop = true;
            this.linkSignup.Text = "No Account? Sign Up";
            this.linkSignup.UseWaitCursor = true;
            this.linkSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignup_LinkClicked);
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbManager.Location = new System.Drawing.Point(56, 248);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(79, 20);
            this.rbManager.TabIndex = 9;
            this.rbManager.TabStop = true;
            this.rbManager.Text = "Manager";
            this.rbManager.UseVisualStyleBackColor = true;
            this.rbManager.CheckedChanged += new System.EventHandler(this.rbManager_CheckedChanged);
            // 
            // rbClient
            // 
            this.rbClient.AutoSize = true;
            this.rbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbClient.Location = new System.Drawing.Point(476, 248);
            this.rbClient.Name = "rbClient";
            this.rbClient.Size = new System.Drawing.Size(58, 20);
            this.rbClient.TabIndex = 10;
            this.rbClient.TabStop = true;
            this.rbClient.Text = "Client";
            this.rbClient.UseVisualStyleBackColor = true;
            this.rbClient.CheckedChanged += new System.EventHandler(this.rbClient_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.lblCode);
            this.groupBox1.Controls.Add(this.loginBtn);
            this.groupBox1.Controls.Add(this.linkSignup);
            this.groupBox1.Controls.Add(this.linkPassword);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(56, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 159);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            this.groupBox1.UseWaitCursor = true;
            // 
            // txtCode
            // 
            this.txtCode.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(108, 110);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(292, 20);
            this.txtCode.TabIndex = 11;
            this.txtCode.UseWaitCursor = true;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(18, 114);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(43, 16);
            this.lblCode.TabIndex = 10;
            this.lblCode.Text = "Code:";
            this.lblCode.UseWaitCursor = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(567, 69);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 26);
            this.loginBtn.TabIndex = 9;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.UseWaitCursor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click_1);
            // 
            // MainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbClient);
            this.Controls.Add(this.rbManager);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pbClient);
            this.Controls.Add(this.pbManager);
            this.Name = "MainLogin";
            this.Text = "Main Login";
            this.Load += new System.EventHandler(this.MainLogin_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClient)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbManager;
        private System.Windows.Forms.PictureBox pbClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel linkPassword;
        private System.Windows.Forms.LinkLabel linkSignup;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.RadioButton rbClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
    }
}

