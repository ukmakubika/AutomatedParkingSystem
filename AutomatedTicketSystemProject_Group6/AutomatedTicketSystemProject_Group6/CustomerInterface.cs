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
    public partial class CustomerInterface : Form
    {
        public CustomerInterface()
        {
            InitializeComponent();
        }

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
        }

        private void cbFAQ_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            int code;
            Random requestedCode = new Random();
            code = requestedCode.Next(10000, 99999);
            DateTime thisday = DateTime.Today;

            listCode.Items.Clear();
            listCode.Items.Add(code.ToString());
            listPrev.Items.Add(code.ToString() + "\t" + thisday.ToString("D"));
        }

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
    }
}
