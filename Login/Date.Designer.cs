namespace Login
{
    partial class Date
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFirstDate = new System.Windows.Forms.Label();
            this.lblSecondDate = new System.Windows.Forms.Label();
            this.lblThirdDate = new System.Windows.Forms.Label();
            this.lblFourthDate = new System.Windows.Forms.Label();
            this.lblFifthDate = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.Highlight;
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(400, 29);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // lblFirstDate
            // 
            this.lblFirstDate.AutoSize = true;
            this.lblFirstDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstDate.Location = new System.Drawing.Point(106, 144);
            this.lblFirstDate.Name = "lblFirstDate";
            this.lblFirstDate.Size = new System.Drawing.Size(59, 22);
            this.lblFirstDate.TabIndex = 1;
            this.lblFirstDate.Text = "label1";
            // 
            // lblSecondDate
            // 
            this.lblSecondDate.AutoSize = true;
            this.lblSecondDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondDate.Location = new System.Drawing.Point(106, 193);
            this.lblSecondDate.Name = "lblSecondDate";
            this.lblSecondDate.Size = new System.Drawing.Size(59, 22);
            this.lblSecondDate.TabIndex = 2;
            this.lblSecondDate.Text = "label2";
            // 
            // lblThirdDate
            // 
            this.lblThirdDate.AutoSize = true;
            this.lblThirdDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdDate.Location = new System.Drawing.Point(106, 241);
            this.lblThirdDate.Name = "lblThirdDate";
            this.lblThirdDate.Size = new System.Drawing.Size(59, 22);
            this.lblThirdDate.TabIndex = 3;
            this.lblThirdDate.Text = "label3";
            // 
            // lblFourthDate
            // 
            this.lblFourthDate.AutoSize = true;
            this.lblFourthDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFourthDate.Location = new System.Drawing.Point(106, 289);
            this.lblFourthDate.Name = "lblFourthDate";
            this.lblFourthDate.Size = new System.Drawing.Size(59, 22);
            this.lblFourthDate.TabIndex = 4;
            this.lblFourthDate.Text = "label4";
            // 
            // lblFifthDate
            // 
            this.lblFifthDate.AutoSize = true;
            this.lblFifthDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFifthDate.Location = new System.Drawing.Point(106, 335);
            this.lblFifthDate.Name = "lblFifthDate";
            this.lblFifthDate.Size = new System.Drawing.Size(59, 22);
            this.lblFifthDate.TabIndex = 5;
            this.lblFifthDate.Text = "label5";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Green;
            this.btnShow.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(582, 373);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(105, 45);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblFifthDate);
            this.Controls.Add(this.lblFourthDate);
            this.Controls.Add(this.lblThirdDate);
            this.Controls.Add(this.lblSecondDate);
            this.Controls.Add(this.lblFirstDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Date";
            this.Text = "Date";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFirstDate;
        private System.Windows.Forms.Label lblSecondDate;
        private System.Windows.Forms.Label lblThirdDate;
        private System.Windows.Forms.Label lblFourthDate;
        private System.Windows.Forms.Label lblFifthDate;
        private System.Windows.Forms.Button btnShow;
    }
}