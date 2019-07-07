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
    public partial class DialogBox : Form
    {
        public DialogBox()
        {
            InitializeComponent();
        }

        private void btnMB_Click(object sender, EventArgs e)
        {
            DialogResult dr =  MessageBox.Show("1. კანეშნა დედა -> yes \n 2. ნუ მამა რაა -> no \n 3. ორივენიცა -> cancel", "დედა უფრო გიყვარს თუ მამა?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                lblYes.Text = "დედიკოს გოგო! ^_^";
            }
            if (dr == DialogResult.No)
            {
                lblNo.Text = "სერიოზულად?";
            }
        }
    }
}
