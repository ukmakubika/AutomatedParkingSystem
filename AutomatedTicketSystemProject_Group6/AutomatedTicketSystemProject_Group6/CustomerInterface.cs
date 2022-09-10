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
    public partial class Functions : Form
    {
        public Functions()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int cardNo;
            int CVV;
            bool isValidCardNo = int.TryParse(txtCardNo.Text, out cardNo);
            bool isValidCVV = int.TryParse(txtCVV.Text, out CVV);

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

             if (!isValidCardNo)
             {
                 MessageBox.Show("Please enter a valid number");

                 if (txtCardNo.Text.Length != 16)
                 {
                     MessageBox.Show("Please enter a valid length card number.");
                 } 
             }
             if (!isValidCVV)
             {
                MessageBox.Show("Please enter a valid number");

                if (txtCVV.Text.Length != 3)
                {
                MessageBox.Show("Please enter a valid length CVV number.");
                }
             }             
        }
    }
}
