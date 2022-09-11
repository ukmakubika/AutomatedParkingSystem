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
    public partial class AddCard : Form
    {
        public AddCard()
        {
            InitializeComponent();
        }

        //Connection of data
        SqlConnection connection;
        string cnctString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TicketSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //Retrieving data
        SqlDataAdapter adapter;
        SqlCommand command;
        DataSet data;

        public string name;
        


        private void btnSave_Click(object sender, EventArgs e)
        {
            float cardNo;
            int CVV;
            if (float.TryParse(txtCardNo.Text, out cardNo))
            {
                if (txtCardNo.Text.Length != 16)
                {
                    MessageBox.Show("Please enter a valid length card number.");
                }
                else
                {
                    if (int.TryParse(txtCVV.Text, out CVV))
                    {
                        if (txtCVV.Text.Length != 3)
                        {
                            MessageBox.Show("Please enter a valid length CVV number.");
                        }
                        else
                        {
                            if (cbBankNames.SelectedItem == null)
                            {
                                MessageBox.Show("Please select a bank");
                            }
                            if (cbMonth.SelectedItem == null)
                            {
                                MessageBox.Show("Please select a month");
                            }
                            if (cbYear.SelectedItem == null)
                            {
                                MessageBox.Show("Please select a year");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid cvv code");
                    }
                }

            }
            else
            {
                MessageBox.Show("Please enter a valid card number");
            }
            try
            {
                txtExpDate.Text =  cbMonth.Text + " " + cbYear.Text;
                string dateExp = txtExpDate.Text;
                var parsedExp = DateTime.Parse(dateExp);

                name = txtCardholderName.Text;

                string addme = $"INSERT INTO BANK(Bank_name, Exp_date, Card_no, Card_HolderName) VALUES('{cbBankNames.Text}', '{txtCardNo.Text}', {parsedExp:d0},'{txtCardholderName.Text}')";//tell to insert in string language

                connection = new SqlConnection(cnctString);//whats it gonna connect to 

                connection.Open(); //open connection

                command = new SqlCommand(addme, connection); //tell it what r=to do
                adapter = new SqlDataAdapter(); //populate data table
                adapter.InsertCommand = command; //tel it to insert
                adapter.InsertCommand.ExecuteNonQuery();

                
                connection.Close(); // close connection
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }


        }
    }
}
