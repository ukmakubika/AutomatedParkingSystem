using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace AutomatedTicketSystemProject_Group6
{
    public partial class MainLogin : Form
    {
        public MainLogin()
        {
            InitializeComponent();
        }

        private void MainLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
 //PabiLexer404_Work
            if (rbClient.Checked)
            {
                ClientSignUp clientFrm = new ClientSignUp();
                clientFrm.ShowDialog();
            }
// main
            if (rbManager.Checked)
            {
                ManagerSignUp managerFrm = new ManagerSignUp();
                managerFrm.ShowDialog();
            }
        }

        private void rbManager_CheckedChanged(object sender, EventArgs e)
        {
            txtCode.Enabled = true;
            lblCode.Visible = true; 
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (rbManager.Checked)
            {
                ManagerInterface managerInt = new ManagerInterface();
                managerInt.ShowDialog();
            }

            if (rbClient.Checked)
            {
                Functions customerInt = new Functions();
                customerInt.ShowDialog();
            }
        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            if (rbManager.Checked)
            {
                ManagerInterface managerInt = new ManagerInterface();
                managerInt.ShowDialog();
            }

            if (rbClient.Checked)
            {
                string userName, password;
                userName = txtUsername.Text;
                password = txtPassword.Text;
                try
                {
                    string userDetails;

                    StreamReader inputFile;
                    inputFile = File.OpenText("UserDetails.txt");

                    while (!inputFile.EndOfStream)
                    {
                        userDetails = inputFile.ReadLine();
                        if (userDetails.Contains(userName) && userDetails.Contains(password))
                        {
                            MessageBox.Show("Logged in");
                            Functions customerInt = new Functions();
                            customerInt.ShowDialog();
                            
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password");
                            
                        }
                        break;
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void rbClient_CheckedChanged(object sender, EventArgs e)
        {
            txtCode.Enabled = false;
            lblCode.Visible = false;
        }

        private void MainLogin_Load_1(object sender, EventArgs e)
        {
            lblCode.Visible = false;
        }
    }
}
