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
    public partial class Radio : Form
    {
        public Radio()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string input;
            if(radioHtml.Checked == true)
            {
                input = radioHtml.Text;
                MessageBox.Show(input + " is the best!");
            }
            if (radioCss.Checked == true)
            {
                input = radioCss.Text;
                MessageBox.Show(input + " is the best!");
            }
            if (radioCsharp.Checked == true)
            {
                input = radioCsharp.Text;
                MessageBox.Show(input + " is the best!");
            }
            if (radioCplusplus.Checked == true)
            {
                input = radioCplusplus.Text;
                MessageBox.Show(input + " is the best!");
            }
            if (radioJava.Checked == true)
            {
                input = radioJava.Text;
                MessageBox.Show(input + " is the best!");
            }
        }
    }
}
