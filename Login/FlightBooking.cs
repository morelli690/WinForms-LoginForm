using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FlightBooking : Form
    {
        public FlightBooking()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                lblNo.Text = "Passport No:";
                lblIssue.Text = "Passport Issue Date:";
                lblExpiry.Text = "Passport Expiry Date:";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblNo.Text = "Id Card No:";
                lblIssue.Text = "Id Card Issue Date:";
                lblExpiry.Text = "Id Card Expiry Date:";
            }
        }
    }
}
