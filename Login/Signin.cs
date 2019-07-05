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
    public partial class Signin : Form
    {
        public static string firstName;
        public static string lastName;
        public static string email;

        public static Boolean html;
        public static Boolean css;
        public static Boolean bootstrap;
        public static Boolean cplusplus;
        public static Boolean csharp;
        public static Boolean java;
        public static Boolean js;
        public static Boolean react;
        public static Boolean php;

        public Signin()
        {
            InitializeComponent();
        }

      
        private void checkBoxHTML_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHTML.Checked)
            {
                html = true;
            }
            else
            {
                html = false;
            }
        }

        private void checkBoxCSS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCSS.Checked)
            {
                css = true;
            }
            else
            {
                css = false;
            }
        }

        private void checkBoxBootstrap_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBootstrap.Checked)
            {
                bootstrap = true;
            }
            else
            {
                bootstrap = false;
            }
        }

        private void checkBoxCplusplus_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCplusplus.Checked)
            {
                cplusplus = true;
            }
            else
            {
                cplusplus = false;
            }
        }

        private void checkBoxCsharp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCsharp.Checked)
            {
                csharp = true;
            }
            else
            {
                csharp = false;
            }
        }

        private void checkBoxJava_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJava.Checked)
            {
                java = true;
            }
            else
            {
                java = false;
            }
        }

        private void checkBoxJS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJS.Checked)
            {
                js = true;
            }
            else
            {
                js = false;
            }
        }

        private void checkBoxReact_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxReact.Checked)
            {
                react = true;
            }
            else
            {
                react = false;
            }
        }

        private void checkBoxPHP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPHP.Checked)
            {
                php = true;
            }
            else
            {
                php = false;
            }
        }
    }
}
