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

namespace AutomatedTicketSystemProject_Group6
{
    public partial class ClientSignUp : Form
    {
        string connectString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TicketSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet data;

        public ClientSignUp()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
                if (txtPassword.Text == txtConfirm.Text)
                {
                    try
                    {
                        string sql = $"INSERT INTO CLIENT(Client_FName, Client_LName, Client_IDNum, Client_Email, Client_ContactNo, Client_UserName) VALUES('{txtName.Text}', '{txtSurname.Text}', '{txtIDNum.Text}', '{txtEmail.Text}', '{txtContact.Text}', '{txtUsername.Text}')";
                        connection = new SqlConnection(connectString);//whats it gonna connect to 
                        connection.Open();

                        command = new SqlCommand(sql, connection); //tell it what r=to do
                        adapter = new SqlDataAdapter(); //populate data table
                        adapter.InsertCommand = command; //tel it to insert
                        adapter.InsertCommand.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Registration Successful");
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            this.Close();     
        }
    }
}
