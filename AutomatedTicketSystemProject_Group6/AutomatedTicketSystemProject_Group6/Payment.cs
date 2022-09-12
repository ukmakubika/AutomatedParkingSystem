using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedTicketSystemProject_Group6
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbCards.ResetText();
            txtCVV.Enabled = true;
            btnPay.Enabled = true;
        }

        private void cbCards_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void Payment_Load(object sender, EventArgs e)
        {
            if (cbCards.SelectedItem != null)
            {
                btnPay.Enabled = true;
            }

            CustomerInterface custInt = new CustomerInterface();

            if (custInt.time < 1)
            {
                listAmountDue.Items.Clear();    
                listAmountDue.Items.Add("Time Spent: " + custInt.time + " Hours");
                listAmountDue.Items.Add("===========================================");
                listAmountDue.Items.Add("Amount Due: R5");
            }
            else if (custInt.time > 1 && custInt.time <6)
            {
                listAmountDue.Items.Clear();
                listAmountDue.Items.Add("Time Spent: " + custInt.time + " Hours");
                listAmountDue.Items.Add("===========================================");
                listAmountDue.Items.Add("Amount Due: R10");
            }
            else 
            {
                listAmountDue.Items.Clear();
                listAmountDue.Items.Add("Time Spent: " + custInt.time + " Hours");
                listAmountDue.Items.Add("===========================================");
                listAmountDue.Items.Add("Amount Due: R40");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            listAmountDue.Items.Clear();
            listAmountDue.Items.Add("===========================================");
            listAmountDue.Items.Add("\t\tAmount Paid");
            listAmountDue.Items.Add("===========================================");

        }
    }
}
