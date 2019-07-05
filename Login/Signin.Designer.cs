namespace Login
{
    partial class Signin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxFName = new System.Windows.Forms.TextBox();
            this.txtBoxLName = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.checkBoxPHP = new System.Windows.Forms.CheckBox();
            this.checkBoxReact = new System.Windows.Forms.CheckBox();
            this.checkBoxJS = new System.Windows.Forms.CheckBox();
            this.checkBoxJava = new System.Windows.Forms.CheckBox();
            this.checkBoxCsharp = new System.Windows.Forms.CheckBox();
            this.checkBoxCplusplus = new System.Windows.Forms.CheckBox();
            this.checkBoxBootstrap = new System.Windows.Forms.CheckBox();
            this.checkBoxCSS = new System.Windows.Forms.CheckBox();
            this.checkBoxHTML = new System.Windows.Forms.CheckBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(83, 66);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(99, 22);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(83, 119);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(96, 22);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(83, 172);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 22);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // txtBoxFName
            // 
            this.txtBoxFName.Location = new System.Drawing.Point(238, 66);
            this.txtBoxFName.Name = "txtBoxFName";
            this.txtBoxFName.Size = new System.Drawing.Size(473, 20);
            this.txtBoxFName.TabIndex = 3;
            // 
            // txtBoxLName
            // 
            this.txtBoxLName.Location = new System.Drawing.Point(238, 119);
            this.txtBoxLName.Name = "txtBoxLName";
            this.txtBoxLName.Size = new System.Drawing.Size(473, 20);
            this.txtBoxLName.TabIndex = 4;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(238, 172);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(473, 20);
            this.txtBoxEmail.TabIndex = 5;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.checkBoxPHP);
            this.groupBox.Controls.Add(this.checkBoxReact);
            this.groupBox.Controls.Add(this.checkBoxJS);
            this.groupBox.Controls.Add(this.checkBoxJava);
            this.groupBox.Controls.Add(this.checkBoxCsharp);
            this.groupBox.Controls.Add(this.checkBoxCplusplus);
            this.groupBox.Controls.Add(this.checkBoxBootstrap);
            this.groupBox.Controls.Add(this.checkBoxCSS);
            this.groupBox.Controls.Add(this.checkBoxHTML);
            this.groupBox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(87, 230);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(624, 191);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Computer Skills";
            // 
            // checkBoxPHP
            // 
            this.checkBoxPHP.AutoSize = true;
            this.checkBoxPHP.Location = new System.Drawing.Point(438, 139);
            this.checkBoxPHP.Name = "checkBoxPHP";
            this.checkBoxPHP.Size = new System.Drawing.Size(71, 30);
            this.checkBoxPHP.TabIndex = 8;
            this.checkBoxPHP.Text = "PHP";
            this.checkBoxPHP.UseVisualStyleBackColor = true;
            this.checkBoxPHP.CheckedChanged += new System.EventHandler(this.checkBoxPHP_CheckedChanged);
            // 
            // checkBoxReact
            // 
            this.checkBoxReact.AutoSize = true;
            this.checkBoxReact.Location = new System.Drawing.Point(438, 103);
            this.checkBoxReact.Name = "checkBoxReact";
            this.checkBoxReact.Size = new System.Drawing.Size(84, 30);
            this.checkBoxReact.TabIndex = 7;
            this.checkBoxReact.Text = "React";
            this.checkBoxReact.UseVisualStyleBackColor = true;
            this.checkBoxReact.CheckedChanged += new System.EventHandler(this.checkBoxReact_CheckedChanged);
            // 
            // checkBoxJS
            // 
            this.checkBoxJS.AutoSize = true;
            this.checkBoxJS.Location = new System.Drawing.Point(438, 67);
            this.checkBoxJS.Name = "checkBoxJS";
            this.checkBoxJS.Size = new System.Drawing.Size(127, 30);
            this.checkBoxJS.TabIndex = 6;
            this.checkBoxJS.Text = "Javascript";
            this.checkBoxJS.UseVisualStyleBackColor = true;
            this.checkBoxJS.CheckedChanged += new System.EventHandler(this.checkBoxJS_CheckedChanged);
            // 
            // checkBoxJava
            // 
            this.checkBoxJava.AutoSize = true;
            this.checkBoxJava.Location = new System.Drawing.Point(245, 139);
            this.checkBoxJava.Name = "checkBoxJava";
            this.checkBoxJava.Size = new System.Drawing.Size(73, 30);
            this.checkBoxJava.TabIndex = 5;
            this.checkBoxJava.Text = "Java";
            this.checkBoxJava.UseVisualStyleBackColor = true;
            this.checkBoxJava.CheckedChanged += new System.EventHandler(this.checkBoxJava_CheckedChanged);
            // 
            // checkBoxCsharp
            // 
            this.checkBoxCsharp.AutoSize = true;
            this.checkBoxCsharp.Location = new System.Drawing.Point(246, 103);
            this.checkBoxCsharp.Name = "checkBoxCsharp";
            this.checkBoxCsharp.Size = new System.Drawing.Size(56, 30);
            this.checkBoxCsharp.TabIndex = 4;
            this.checkBoxCsharp.Text = "C#";
            this.checkBoxCsharp.UseVisualStyleBackColor = true;
            this.checkBoxCsharp.CheckedChanged += new System.EventHandler(this.checkBoxCsharp_CheckedChanged);
            // 
            // checkBoxCplusplus
            // 
            this.checkBoxCplusplus.AutoSize = true;
            this.checkBoxCplusplus.Location = new System.Drawing.Point(246, 67);
            this.checkBoxCplusplus.Name = "checkBoxCplusplus";
            this.checkBoxCplusplus.Size = new System.Drawing.Size(72, 30);
            this.checkBoxCplusplus.TabIndex = 3;
            this.checkBoxCplusplus.Text = "C++";
            this.checkBoxCplusplus.UseVisualStyleBackColor = true;
            this.checkBoxCplusplus.CheckedChanged += new System.EventHandler(this.checkBoxCplusplus_CheckedChanged);
            // 
            // checkBoxBootstrap
            // 
            this.checkBoxBootstrap.AutoSize = true;
            this.checkBoxBootstrap.Location = new System.Drawing.Point(28, 139);
            this.checkBoxBootstrap.Name = "checkBoxBootstrap";
            this.checkBoxBootstrap.Size = new System.Drawing.Size(125, 30);
            this.checkBoxBootstrap.TabIndex = 2;
            this.checkBoxBootstrap.Text = "Bootsrtap";
            this.checkBoxBootstrap.UseVisualStyleBackColor = true;
            this.checkBoxBootstrap.CheckedChanged += new System.EventHandler(this.checkBoxBootstrap_CheckedChanged);
            // 
            // checkBoxCSS
            // 
            this.checkBoxCSS.AutoSize = true;
            this.checkBoxCSS.Location = new System.Drawing.Point(28, 103);
            this.checkBoxCSS.Name = "checkBoxCSS";
            this.checkBoxCSS.Size = new System.Drawing.Size(66, 30);
            this.checkBoxCSS.TabIndex = 1;
            this.checkBoxCSS.Text = "CSS";
            this.checkBoxCSS.UseVisualStyleBackColor = true;
            this.checkBoxCSS.CheckedChanged += new System.EventHandler(this.checkBoxCSS_CheckedChanged);
            // 
            // checkBoxHTML
            // 
            this.checkBoxHTML.AutoSize = true;
            this.checkBoxHTML.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxHTML.Location = new System.Drawing.Point(28, 67);
            this.checkBoxHTML.Name = "checkBoxHTML";
            this.checkBoxHTML.Size = new System.Drawing.Size(89, 30);
            this.checkBoxHTML.TabIndex = 0;
            this.checkBoxHTML.Text = "HTML";
            this.checkBoxHTML.UseVisualStyleBackColor = true;
            this.checkBoxHTML.CheckedChanged += new System.EventHandler(this.checkBoxHTML_CheckedChanged);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(611, 468);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(100, 40);
            this.btnSignIn.TabIndex = 7;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 558);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxLName);
            this.Controls.Add(this.txtBoxFName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "Signin";
            this.Text = "Signin";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxFName;
        private System.Windows.Forms.TextBox txtBoxLName;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.CheckBox checkBoxPHP;
        private System.Windows.Forms.CheckBox checkBoxReact;
        private System.Windows.Forms.CheckBox checkBoxJS;
        private System.Windows.Forms.CheckBox checkBoxJava;
        private System.Windows.Forms.CheckBox checkBoxCsharp;
        private System.Windows.Forms.CheckBox checkBoxCplusplus;
        private System.Windows.Forms.CheckBox checkBoxBootstrap;
        private System.Windows.Forms.CheckBox checkBoxCSS;
        private System.Windows.Forms.CheckBox checkBoxHTML;
        private System.Windows.Forms.Button btnSignIn;
    }
}