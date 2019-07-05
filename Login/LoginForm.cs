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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUserName.Text;
            string password = txtBoxPassword.Text;

            if(username == "Ryu" && password == "222")
            {
                this.Close();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxUserName.Text = "";
            txtBoxPassword.Text = "";
        }
    }
}
