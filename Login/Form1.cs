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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnSet_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Hello New Life!";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Noone can cancel you!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHello.Text = "Hello New World!";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signin signin = new Signin();
            signin.Show();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Date date = new Date();
            date.Show();
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Radio radio = new Radio();
            radio.Show();
        }

        private void btnDialog_Click(object sender, EventArgs e)
        {
            this.Hide();
            DialogBox dialogBox = new DialogBox();
            dialogBox.Show();
        }

        private void btnFlightApp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlightBooking flightBooking = new FlightBooking();
            flightBooking.Show();
        }
    }
}
