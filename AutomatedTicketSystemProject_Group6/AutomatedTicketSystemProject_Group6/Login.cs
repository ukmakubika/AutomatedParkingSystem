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

        public string userName;

        private void MainLogin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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
                        string password, code;
                        userName = txtUsername.Text;
                        password = txtPassword.Text;
                        code = txtCode.Text;
                        try
                        {
                            string[] managerDetails = File.ReadAllText("ManagerDetails.txt").Split(' ');
                            string managerSearch = userName;
                            string passwordSearch = password;
                            string codeSearch = code;
                            bool condition1 = false;
                            bool condition2 = false;
                            bool condition3 = false;
                            for (int i = 0; i < managerDetails.Length; i++)
                            {
                                if (managerDetails[i].Contains(managerSearch) == true)
                                {
                                    condition1 = true;
                                    break;
                                }
                                else
                                {
                                    condition1 = false;
                                }

                            }
                            for (int i = 0; i < managerDetails.Length; i++)
                            {
                                if (managerDetails[i].Contains(passwordSearch) == true)
                                {
                                    condition2 = true;
                                    break;
                                }
                                else
                                {
                                    condition2 = false;
                                }
                            }
                            for (int i = 0; i < managerDetails.Length; i++)
                            {
                                if (managerDetails[i].Contains(codeSearch) == true)
                                {
                                    condition3 = true;
                                    break;
                                }
                                else
                                {
                                    condition3 = false;
                                }

                            }
                            if ((condition1 == true))
                            {
                                if (condition2 == true)
                                {
                                    if (condition3 == true)
                                    {
                                        MessageBox.Show("Logged in");
                                        ManagerInterface managerFrm = new ManagerInterface();
                                        managerFrm.ShowDialog();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid Manager Code");
                                        txtCode.Text = " ";
                                        txtCode.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid password");
                                    txtPassword.Text = " ";
                                    txtPassword.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username");
                                txtUsername.Text = " ";
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

                        string[] userDetails = File.ReadAllText("UserDetails.txt").Split(' ');
                        string userSearch = userName;
                        string passwordSearch = password;
                        bool condition1 = false;
                        bool condition2 = false;
                        for (int i = 0; i < userDetails.Length; i++)
                        {
                            if (userDetails[i].Contains(userSearch) == true)
                            {
                                condition1 = true;
                                break;
                            }
                            else
                            {
                                condition1 = false;
                            }

                        }
                        for (int i = 0; i < userDetails.Length; i++)
                        {
                            if (userDetails[i].Contains(passwordSearch) == true)
                            {
                                condition2 = true;
                                break;
                            }
                            else
                            {
                                condition2 = false;
                            }
                        }
                        if ((condition1 == true))
                        {
                            if (condition2 == true)
                            {
                                MessageBox.Show("Logged in");
                                CustomerInterface customerInt = new CustomerInterface();
                                customerInt.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Invalid password");
                                txtPassword.Text = " ";
                                txtPassword.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username");
                            txtUsername.Text = " ";
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
    }
}
