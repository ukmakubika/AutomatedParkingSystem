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
using System.Data.Sql;

namespace AutomatedTicketSystemProject_Group6
{
    public partial class ManagerInterface : Form
    {
        public ManagerInterface()
        {
            InitializeComponent();
        }
        string connectString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TicketSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        DataSet dataSet;
        private void cbFAQ_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cbFAQ.SelectedItem.ToString() == "What do I do if I forget my manager code?")
            {
                listAnswer.Items.Clear();
                listAnswer.Items.Add("Choose the edit account details page and");
                listAnswer.Items.Add("select the recover code option and complete the verification steps.");
            }

            if (cbFAQ.SelectedItem.ToString() == "What do I do if I forget my password?")
            {
                listAnswer.Items.Clear();
                listAnswer.Items.Add("Choose the edit account details page and");
                listAnswer.Items.Add("select the recover password option and complete the verification steps.");
            }

            if (cbFAQ.SelectedItem.ToString() == "Can I use the app to request a mall code similarly to a customer?")
            {
                listAnswer.Items.Clear();
                listAnswer.Items.Add("Yes.");
                
            }

            if (cbFAQ.SelectedItem.ToString() == "How can I see my top customers?")
            {

            }

        }



        private void btnCreate_Click(object sender, EventArgs e)
        {
            rbLowToHigh.Enabled = true;
            rbHighToLow.Enabled = true;
            rbName.Enabled = true;
            rbLongestHours.Enabled = true;
            if (rbName.Checked)
            {
                try
                {
                    connection = new SqlConnection(connectString);

                    connection.Open();
                    string sql = "SELECT Client_FName, Client_LName FROM CLIENT";
                    command = new SqlCommand(sql, connection);
                    reader = command.ExecuteReader();
                    listOutput.Items.Clear();

                    while (reader.Read())
                    {
                        listOutput.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1));
                    }

                    connection.Close();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }

            if (rbHighToLow.Checked)
            {
                try
                {
                    connection = new SqlConnection(connectString);

                    connection.Open();
                    string sql = "SELECT Bank_name FROM BANK";
                    command = new SqlCommand(sql, connection);
                    reader = command.ExecuteReader();
                    listOutput.Items.Clear();

                    while (reader.Read())
                    {
                        listOutput.Items.Add(reader.GetValue(0) + "\n" + reader.GetValue(1) + "\n" + reader.GetValue(2));
                    }

                    connection.Close();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void cbGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGeneral.Items != null)
            {
                rbLowToHigh.Enabled = true;
                rbHighToLow.Enabled = true;
                rbName.Enabled = true;
                rbLongestHours.Enabled = true;
            }
            else
            {
                rbLowToHigh.Enabled = false;
                rbHighToLow.Enabled = false;
                rbName.Enabled = false;
                rbLongestHours.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbGeneral.ResetText();
            rbLowToHigh.Enabled = false;
            rbHighToLow.Enabled = false;
            rbName.Enabled = false;
            rbLongestHours.Enabled = false;

        }

        private void checkCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCustom.Checked)
            {
                txtCustomName.Enabled = true;
                btnCreate.Enabled = true;
            }
            else
            {
                txtCustomName.Enabled = false;
                btnCreate.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rbLongestHours_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbHighToLow_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
