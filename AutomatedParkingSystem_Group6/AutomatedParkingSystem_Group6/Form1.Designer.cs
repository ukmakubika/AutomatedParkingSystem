namespace AutomatedParkingSystem_Group6
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
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            this.components = new System.ComponentModel.Container();
=======
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(337, 232);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Testing";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
>>>>>>> Stashed changes
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTest);
            this.Name = "Form1";
            this.Text = "AutomatedParkingSystem";
            this.ResumeLayout(false);

        }

        #endregion
<<<<<<< Updated upstream
=======
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.rbClient = new System.Windows.Forms.RadioButton();
            this.pbManager = new System.Windows.Forms.PictureBox();
            this.pbClient = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.linkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.linkSignUp = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClient)).BeginInit();
            this.SuspendLayout();
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Location = new System.Drawing.Point(86, 165);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(67, 17);
            this.rbManager.TabIndex = 0;
            this.rbManager.TabStop = true;
            this.rbManager.Text = "Manager";
            this.rbManager.UseVisualStyleBackColor = true;
            // 
            // rbClient
            // 
            this.rbClient.AutoSize = true;
            this.rbClient.Location = new System.Drawing.Point(399, 165);
            this.rbClient.Name = "rbClient";
            this.rbClient.Size = new System.Drawing.Size(51, 17);
            this.rbClient.TabIndex = 1;
            this.rbClient.TabStop = true;
            this.rbClient.Text = "Client";
            this.rbClient.UseVisualStyleBackColor = true;
            this.rbClient.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // pbManager
            // 
            this.pbManager.Location = new System.Drawing.Point(64, 37);
            this.pbManager.Name = "pbManager";
            this.pbManager.Size = new System.Drawing.Size(129, 122);
            this.pbManager.TabIndex = 2;
            this.pbManager.TabStop = false;
            // 
            // pbClient
            // 
            this.pbClient.Location = new System.Drawing.Point(361, 37);
            this.pbClient.Name = "pbClient";
            this.pbClient.Size = new System.Drawing.Size(129, 122);
            this.pbClient.TabIndex = 3;
            this.pbClient.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(224, 206);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(131, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(224, 240);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(131, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // linkForgotPassword
            // 
            this.linkForgotPassword.AutoSize = true;
            this.linkForgotPassword.Location = new System.Drawing.Point(12, 327);
            this.linkForgotPassword.Name = "linkForgotPassword";
            this.linkForgotPassword.Size = new System.Drawing.Size(92, 13);
            this.linkForgotPassword.TabIndex = 8;
            this.linkForgotPassword.TabStop = true;
            this.linkForgotPassword.Text = "Forgot Password?";
            // 
            // linkSignUp
            // 
            this.linkSignUp.AutoSize = true;
            this.linkSignUp.Location = new System.Drawing.Point(12, 307);
            this.linkSignUp.Name = "linkSignUp";
            this.linkSignUp.Size = new System.Drawing.Size(111, 13);
            this.linkSignUp.TabIndex = 9;
            this.linkSignUp.TabStop = true;
            this.linkSignUp.Text = "No Account? Sign-Up";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(251, 282);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // MainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 359);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.linkSignUp);
            this.Controls.Add(this.linkForgotPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbClient);
            this.Controls.Add(this.pbManager);
            this.Controls.Add(this.rbClient);
            this.Controls.Add(this.rbManager);
            this.Name = "MainLogin";
            this.Text = "Main Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.RadioButton rbClient;
        private System.Windows.Forms.PictureBox pbManager;
        private System.Windows.Forms.PictureBox pbClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel linkForgotPassword;
        private System.Windows.Forms.LinkLabel linkSignUp;
        private System.Windows.Forms.Button btnLogin;
>>>>>>> Stashed changes
=======

        private System.Windows.Forms.Button btnTest;
>>>>>>> Stashed changes
    }
}

