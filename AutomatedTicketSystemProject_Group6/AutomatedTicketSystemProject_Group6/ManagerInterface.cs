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
    public partial class ManagerInterface : Form
    {
        public ManagerInterface()
        {
            InitializeComponent();
        }

        private void ManagerInterface_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
