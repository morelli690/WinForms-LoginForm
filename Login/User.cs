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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            lblYourName.Text = Signin.firstName;
            lblYourSurename.Text = Signin.lastName;
            lblYourEmail.Text = Signin.email;

            if (Signin.html)
            {
                html.Text = "✓";
            }
            if (Signin.css)
            {
                css.Text = "✓";
            }
            if (Signin.bootstrap)
            {
                bootstrap.Text = "✓";
            }

            if (Signin.cplusplus)
            {
                cplusplus.Text = "✓";
            }
            if (Signin.csharp)
            {
                csharp.Text = "✓";
            }
            if (Signin.java)
            {
                java.Text = "✓";
            }


            if (Signin.js)
            {
                js.Text = "✓";
            }
            if (Signin.react)
            {
                react.Text = "✓";
            }
            if (Signin.php)
            {
                php.Text = "✓";
            }
        }
    }
}
