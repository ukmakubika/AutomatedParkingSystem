using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutomatedTicketSystemProject_Group6
{
    public partial class ManagerSignUp : Form
    {
        public ManagerSignUp()
        {
            InitializeComponent();
        }
        string name, surname, email, contactNo, userName;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string password, confirmPassword, securityQuestion, answer, code;
        private void ManagerSignUp_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                name = txtName.Text;
                surname = txtSurname.Text;
                email = txtEmail.Text;
                contactNo = txtNumber.Text;
                userName = txtUsername.Text;
                password = txtPassword.Text;
                confirmPassword = txtConfirm.Text;
                securityQuestion = cbSecurity.Text;
                answer = txtAnswer.Text;
                code = txtCode.Text;

                if (password == confirmPassword)
                {
                    StreamWriter outputFile;

                    outputFile = File.AppendText("ManagerDetails.txt");

                    outputFile.WriteLine(userName + " " + password + " " + securityQuestion + " " + answer + " " + code);

                    outputFile.Close();

                    MessageBox.Show("Profile made successfully.");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
