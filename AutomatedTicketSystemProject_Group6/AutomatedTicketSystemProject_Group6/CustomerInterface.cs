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
    public partial class CustomerInterface : Form
    {
        public CustomerInterface()
        {
            InitializeComponent();
        }

        public int code;
        public int time;

        //Connection of data
        SqlConnection connection;
        string cnctString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TicketSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //Retrieving data
        SqlDataAdapter adapter;
        SqlCommand command;
        DataSet data;

        private void cbFAQ_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbFAQ.SelectedItem.ToString() == "Where can I get my Requested Code code?")
            {
                listAnswer.Items.Clear();
                listAnswer.Items.Add("Press the Request Code button on the Main Page.");
                listAnswer.Items.Add("Your code will appear in the display box.");
            }
            if (cbFAQ.SelectedItem.ToString() == "Which bank cards are accepted on the Automated Parking System?")
            {
                listAnswer.Items.Clear();
                listAnswer.Items.Add("The banks availible on the Automated Parking System");
                listAnswer.Items.Add("can be found in the Payment Details page when you click");
                listAnswer.Items.Add("the Bank Name selection box.");
            }
            if (cbFAQ.SelectedItem.ToString() == "Is there a fee to use the Automated Parking System app?")
            {
                listAnswer.Items.Clear();
                listAnswer.Items.Add("No. Automated Parking System is a free-to-use");
            }
            if (cbFAQ.SelectedItem.ToString() == "How do I add/remove a bank card on the \nAutomated Parking System app?")
            {
                listAnswer.Items.Clear();
                listAnswer.Items.Add("Under the Payment Details tab, Press the Add New button");
                listAnswer.Items.Add("to add a new card and press the Remove Card option to");
                listAnswer.Items.Add("remove a card of your choosing.");
            }
            if (cbFAQ.SelectedItem.ToString() == "How do I set default card on the Automated Parking System app?")
            {
                listAnswer.Items.Clear();
                listAnswer.Items.Add("Under the Payment Deatils tab,");
                listAnswer.Items.Add("Click the set default button");
                listAnswer.Items.Add("and select the card you would like to set as your default.");
            }
            if (cbFAQ.SelectedItem.ToString() == "What if I forget my password?")
            {
                listAnswer.Items.Clear();
                listAnswer.Items.Add("Choose the edit account details page and");
                listAnswer.Items.Add("select the change password option.");
            }
        }

        private void btnRequest_Click_1(object sender, EventArgs e)
        {

            //int code;
            listCode.Items.Clear();
            
            Random requestedCode = new Random();
            code = requestedCode.Next(10000, 99999);
            DateTime thisday = DateTime.Today;

            listCode.Items.Add(code.ToString());

            btnStart.Enabled = true;
            btnStop.Enabled = true;
            btnPay.Enabled = true;
            

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCard addCard = new AddCard();
            addCard.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteNow = "DELETE from BANK WHERE Card_no = '" + txtDelete.Text + "'";
            connection.Open();

            command = new SqlCommand(deleteNow, connection); //"transalte" what your command is
            adapter = new SqlDataAdapter(); //we need to adapt our data
            adapter.DeleteCommand = command; //tell program that it has to delete something in its lanague
            adapter.DeleteCommand.ExecuteNonQuery(); //tell it to execute now

            //String, command, adapter, delete, execute
            connection.Close();

            loadAll();
        }

        private void PaymentDetails_Click(object sender, EventArgs e)
        {

        }

        

        private void loadAll()
        {
            
        }

        private void txtDisplay_Click(object sender, EventArgs e)
        {
            AddCard addCard = new AddCard();
            connection = new SqlConnection(cnctString);
            connection.Open();

            //retrieve data
            adapter = new SqlDataAdapter();
            string sql = "SELECT * from BANK WHERE Card_HolderName = '" + addCard.name + "'";
            command = new SqlCommand(sql, connection);
            adapter.SelectCommand = command;

            //display data
            data = new DataSet();
            adapter.Fill(data, "SourceTable");
            dbBankAccounts.DataSource = data;
            dbBankAccounts.DataMember = "SourceTable";

            connection.Close();

            //adapter, command, selectcommand, dataset, adapter, datasource, datamember
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isActive = false;
            timeS = 0;
            timeMin = 0;
            timeH = 0;

            //timeTracker.Stop();

            DateTime thisday = DateTime.Today;

            time = int.Parse(timeMinutes.Text);  

            listPrev.Items.Add(code.ToString() + "\t" + thisday.ToString("D"));
            listPrev.Items.Add("-------------------------------------------------------------");
            listPrev.Items.Add("Time Elapsed: " + timeHours.Text + ":" + String.Format("{0:00}", timeMin).ToString() + ":" + timeSeconds.Text);
            listPrev.Items.Add("-------------------------------------------------------------");
        }

        private void timeTracker_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timeS++;

                if (timeS >= 60)
                {
                    timeMin++;
                    timeS = 0;

                    if (timeMin >= 60)
                    {
                        timeH++;
                        timeMin = 0;
                    }
                }
               
            }
            ShowTime();
           
        }

        public void ShowTime()
        {
            timeSeconds.Text = String.Format("{0:00}", timeS);
            timeMinutes.Text = String.Format("{0:00}", timeMin);
            timeHours.Text = String.Format("{0:00}", timeH);
        }

        int timeS, timeMin, timeH;
        bool isActive;

        private void btnStart_Click(object sender, EventArgs e)
        {
            //timeTracker.Start();
            

            isActive = true;
        }

        private void CustomerInterface_Load(object sender, EventArgs e)
        {
            loadAll();

            listPrev.Items.Add("Code \t Today");
            listPrev.Items.Add("===============================");

            timeS = 0;
            timeMin = 0;
            timeH = 0;

            isActive = false;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.ShowDialog();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
