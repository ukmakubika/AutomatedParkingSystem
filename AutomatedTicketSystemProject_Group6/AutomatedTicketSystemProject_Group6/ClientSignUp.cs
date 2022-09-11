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
using System.Data.Sql;

namespace AutomatedTicketSystemProject_Group6
{
    public partial class ClientSignUp : Form
    {
        string name, surname, email, idNum; 
        string userName, contactNo, password, securityQuestion, confirmPassword, answer;
        string connectString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TicketSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet data;
        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            
            
            try
            {
                name = txtName.Text;
                surname = txtSurname.Text;
                email = txtEmail.Text;
                idNum = txtIDNum.Text;
                userName = txtUsername.Text;
                contactNo = txtContact.Text;

                password = txtPassword.Text;
                confirmPassword = txtConfirm.Text;
                securityQuestion = cbSecurity.Text;
                answer = txtAnswer.Text;

                if (password == confirmPassword)
                {
                    StreamWriter outputFile;

                    outputFile = File.AppendText("UserDetails.txt");

                    outputFile.WriteLine(userName + " " + password + " " + securityQuestion + " " + answer);

                    outputFile.Close();

                    try
                    {
                        connection = new SqlConnection(connectString);

                        connection.Open();
                        string sqlInsert = $"INSERT INTO CLIENT(Client_FName, Client_LName, Client_IDNum, Client_Email, Client_ContactNo, Client_UserName) VALUES('{name}', '{surname}', '{idNum}', '{email}', '{contactNo}', '{userName}')";
                        command = new SqlCommand(sqlInsert, connection);
                        adapter = new SqlDataAdapter();
                        adapter.InsertCommand = command;
                        adapter.InsertCommand.ExecuteNonQuery();

                        connection.Close();
                            
                        MessageBox.Show("Account Created Successfully");

                        this.Close();
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message);
                    }


                }
                else
                {
                    MessageBox.Show("Passwords don't match");
                    txtConfirm.Text = "";
                    txtConfirm.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public ClientSignUp()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            /*string connectString = @"Data Source=LAPTOP-9UVIJHCO;Initial Catalog=TicketSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter;
            DataSet data;
            try
            {
                name = txtName.Text;
                surname = txtSurname.Text;
                email = txtEmail.Text;
                idNum = txtIDNum.Text;
                userName = txtUsername.Text;
                contactNo = txtContact.Text;

                password = txtPassword.Text;
                confirmPassword = txtConfirm.Text;
                securityQuestion = cbSecurity.Text;
                answer = txtAnswer.Text;

                if (password == confirmPassword)
                {
                    StreamWriter outputFile;

                    outputFile = File.AppendText("UserDetails.txt");

                    outputFile.WriteLine(userName, password, securityQuestion, answer);

                    outputFile.Close();

                    try
                    {
                        connection = new SqlConnection(connectString);

                        connection.Open();
                        string sql = $"INSERT INTO CLIENT(Client_FName, Client_LName, Client_IDNum, Client_Email, Client_ContactNo, Client_UserName)" +
                            $" VAULES('{name}', '{surname}', '{idNum}', '{email}', '{contactNo}', '{userName}')";

                        command = new SqlCommand(sql, connection);
                        adapter = new SqlDataAdapter();
                        adapter.InsertCommand = command;
                        adapter.InsertCommand.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Account Created Successfully");

                        this.Close();
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message);
                    }


                }
                else
                {
                    MessageBox.Show("Passwords don't match");
                    txtConfirm.Text = "";
                    txtConfirm.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
    }
}
