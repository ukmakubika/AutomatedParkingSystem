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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length != 0 && txtAnswer.Text.Length != 0 && txtNewPassword.Text.Length != 0 && txtConfirm.Text.Length != 0)
            {
                if (rbManager.Checked)
                {
                    
                    if (txtCode.Text.Length != 0)
                    {
                        string username, answer, securityQuestion, newPassword, passwordConfirm, code;

                        username = txtUsername.Text;
                        securityQuestion = cbQuestion.Text;
                        answer = txtAnswer.Text;
                        newPassword = txtNewPassword.Text;
                        passwordConfirm = txtConfirm.Text;
                        code = txtCode.Text;

                        if (newPassword == passwordConfirm)
                        {
                            try
                            {
                                string[] managerDetails = File.ReadAllText("ManagerDetails.txt").Split(' ');
                                string managerSearch = username;
                                string questionSearch = securityQuestion;
                                string answerSearch = answer;
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
                                    if (managerDetails[i].Contains(answerSearch) == true)
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
                                            StreamWriter outputFile;

                                            outputFile = File.AppendText("ManagerDetails.txt");

                                            outputFile.WriteLine(username + " " + newPassword + " " + securityQuestion + " " + answer + " " + code);

                                            outputFile.Close();

                                            MessageBox.Show("Password changed successfully.");

                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Manager code error");
                                            txtAnswer.Text = " ";
                                            txtAnswer.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid Answer Code");
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
                        else
                        {
                            MessageBox.Show("Passwords don't match");
                        }
                    }
                    
                }
                if (rbClient.Checked)
                {
                    string username, answer, securityQuestion, newPassword, passwordConfirm;

                    username = txtUsername.Text;
                    securityQuestion = cbQuestion.Text;
                    answer = txtAnswer.Text;
                    newPassword = txtNewPassword.Text;
                    passwordConfirm = txtConfirm.Text;

                    if (newPassword == passwordConfirm)
                    {
                        try
                        {
                            string[] managerDetails = File.ReadAllText("UserDetails.txt").Split(' ');
                            string userSearch = username;
                            string questionSearch = securityQuestion;
                            string answerSearch = answer;
                            bool condition1 = false;
                            bool condition2 = false;
                            for (int i = 0; i < managerDetails.Length; i++)
                            {
                                if (managerDetails[i].Contains(userSearch) == true)
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
                                if (managerDetails[i].Contains(answer) == true)
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
                                    StreamWriter outputFile;
                                    outputFile = File.AppendText("UserDetails.txt");

                                    outputFile.WriteLine(username + " " + newPassword + " " + securityQuestion + " " + answer);

                                    outputFile.Close();
                                    MessageBox.Show("Password changed successfully!");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Answer to Question");
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
                    else
                    {
                        MessageBox.Show("Passwords don't match");
                    }

                }
            }
            else
            {
                MessageBox.Show("Fill in all the fields");
            }
            
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            txtCode.Enabled = false;
            label6.Visible = false;
        }

        private void rbManager_CheckedChanged(object sender, EventArgs e)
        {
            txtCode.Enabled = true;
            label6.Visible = true;
        }

        private void rbClient_CheckedChanged(object sender, EventArgs e)
        {
            txtCode.Enabled = false;
            label6.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
