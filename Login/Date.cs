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
    public partial class Date : Form
    {
        public Date()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblFirstDate.Text = dateTimePicker1.Value.ToString();
            lblSecondDate.Text = dateTimePicker1.Value.ToShortDateString();
            lblThirdDate.Text = dateTimePicker1.Value.ToShortTimeString();
            lblFourthDate.Text = dateTimePicker1.Value.ToLongDateString();
            lblFifthDate.Text = dateTimePicker1.Value.ToLongTimeString();
            lblSixthDate.Text = dateTimePicker1.Value.ToString("MMM dd yyyy");

        }
    }
}
