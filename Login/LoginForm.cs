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

        private void login()
        {
            string username = txtBoxUserName.Text;
            string password = txtBoxPassword.Text;

            if (username == "Ryu" && password == "222")
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect!");
            }
        }

        private void reset()
        {
            txtBoxUserName.Text = "";
            txtBoxPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void txtBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                reset();
            }
        }
    }
}
