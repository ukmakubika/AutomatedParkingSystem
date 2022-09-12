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

        //Connection of data
        SqlConnection connection;
        string cnctString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TicketSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //Retrieving data
        SqlDataAdapter adapter;
        SqlCommand command;
        DataSet data;

        private void btnRequest_Click_1(object sender, EventArgs e)
        {
            int code;
            Random requestedCode = new Random();
            code = requestedCode.Next(10000, 99999);
            DateTime thisday = DateTime.Today;

            listCode.Items.Clear();
            listCode.Items.Add(code.ToString());
            listPrev.Items.Add(code.ToString() + "\t" + thisday.ToString("D"));
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

        private void CustomerInterface_Load(object sender, EventArgs e)
        {
            loadAll();
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

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }
    }
}
