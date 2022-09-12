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
                CustomerInterface customerInt = new CustomerInterface();
                customerInt.ShowDialog();
            }
        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            if(txtUsername.Text.Length == 0 && txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter details");
                txtUsername.Focus();
            }
            else
            {
                if (rbManager.Checked)
                {
                    if (txtCode.Text.Length == 0)
                    {
                        MessageBox.Show("Please enter valid code");
                        txtCode.Focus();
                    }
                    else
                    {
                        string userName, password, code;
                        userName = txtUsername.Text;
                        password = txtPassword.Text;
                        code = txtCode.Text;
                        try
                        {
                            string managerDetails = " ";

                            StreamReader inputFile;
                            inputFile = File.OpenText("ManagerDetails.txt");

                            while (!inputFile.EndOfStream)
                            {
                                managerDetails += inputFile.ReadLine();
                            }
                            if ((managerDetails.Contains(userName)) && (managerDetails.Contains(password)) && (managerDetails.Contains(code)))
                            {
                                MessageBox.Show("Logged in");
                                ManagerInterface managerFrm = new ManagerInterface();
                                managerFrm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect login details");
                                txtUsername.Text = " ";
                                txtPassword.Text = " ";
                                txtCode.Text = " ";
                                txtUsername.Focus();
                            }
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.Message);
                        }                    
                                             
                    }

                }

                if (rbClient.Checked)
                {
                    string userName, password;
                    userName = txtUsername.Text;
                    password = txtPassword.Text;
                    try
                    {
                        string userDetails = " ";

                        StreamReader inputFile;
                        inputFile = File.OpenText("UserDetails.txt");

                        while (!inputFile.EndOfStream)
                        {
                            userDetails += inputFile.ReadLine();
                            
                            
                        }
                        if (File.ReadAllText("UserDetails.txt").Contains(userName))
                        {
                            if (File.ReadAllText("UserDetails.txt").Contains(password))
                            {
                                MessageBox.Show("Logged in");
                                CustomerInterface customerInt = new CustomerInterface();
                                customerInt.ShowDialog();
                            }
                            

                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password");
                            txtUsername.Text = " ";
                            txtPassword.Text = " ";
                            txtUsername.Focus();
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
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

        private void linkPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Open forgot password form
            ForgotPassword passwordFrm = new ForgotPassword();
            passwordFrm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
