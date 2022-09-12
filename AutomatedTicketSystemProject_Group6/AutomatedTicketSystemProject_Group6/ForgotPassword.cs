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
                    txtCode.Enabled = true;
                    label6.Visible = true;
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
                                string managerDetails = " ";

                                StreamReader inputFile;
                                inputFile = File.OpenText("ManagerDetails.txt");

                                while (!inputFile.EndOfStream)
                                {
                                    managerDetails += inputFile.ReadLine();
                                }
                                if ((managerDetails.Contains(username)) && (managerDetails.Contains(securityQuestion)) && (managerDetails.Contains(answer)) && (managerDetails.Contains(code)))
                                {
                                    StreamWriter outputFile;
                                    outputFile = File.AppendText("ManagerDetails.txt");

                                    outputFile.WriteLine(username + " " + newPassword + " " + securityQuestion + " " + answer + " " + code);

                                    outputFile.Close();
                                    MessageBox.Show("Password changed successfully!");
                                    this.Close();
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
                    txtCode.Enabled = false;
                    label6.Visible = false;
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
                            string clientDetails = " ";

                            StreamReader inputFile;
                            inputFile = File.OpenText("UserDetails.txt");

                            while (!inputFile.EndOfStream)
                            {
                                clientDetails += inputFile.ReadLine();
                            }
                            if ((clientDetails.Contains(username)) && (clientDetails.Contains(securityQuestion)) && (clientDetails.Contains(answer)))
                            {
                                StreamWriter outputFile;
                                outputFile = File.AppendText("UserDetails.txt");

                                outputFile.WriteLine(username + " " + newPassword + " " + securityQuestion + " " + answer);

                                outputFile.Close();
                                MessageBox.Show("Password changed successfully!");
                                this.Close();
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
                else
                {
                    MessageBox.Show("Please indicate whether you are a client or manager");
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
    }
}
