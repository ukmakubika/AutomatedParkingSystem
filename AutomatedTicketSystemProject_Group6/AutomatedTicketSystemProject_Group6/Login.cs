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

namespace AutomatedTicketSystemProject_Group6
{
    public partial class MainLogin : Form
    {
        public MainLogin()
        {
            InitializeComponent();
        }

        private void MainLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
 //PabiLexer404_Work
            if (rbClient.Checked)
            {
                ClientSignUp clientFrm = new ClientSignUp();
                clientFrm.ShowDialog();
            }
// main
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
