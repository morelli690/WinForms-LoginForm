namespace Login
{
    partial class DialogBox
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
            this.btnMB = new System.Windows.Forms.Button();
            this.lblYes = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMB
            // 
            this.btnMB.AutoSize = true;
            this.btnMB.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMB.Location = new System.Drawing.Point(305, 120);
            this.btnMB.Name = "btnMB";
            this.btnMB.Size = new System.Drawing.Size(148, 36);
            this.btnMB.TabIndex = 0;
            this.btnMB.Text = "Message Box";
            this.btnMB.UseVisualStyleBackColor = true;
            this.btnMB.Click += new System.EventHandler(this.btnMB_Click);
            // 
            // lblYes
            // 
            this.lblYes.AutoSize = true;
            this.lblYes.Location = new System.Drawing.Point(200, 232);
            this.lblYes.Name = "lblYes";
            this.lblYes.Size = new System.Drawing.Size(10, 13);
            this.lblYes.TabIndex = 1;
            this.lblYes.Text = ".";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(200, 277);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(10, 13);
            this.lblNo.TabIndex = 2;
            this.lblNo.Text = ".";
            // 
            // DialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblYes);
            this.Controls.Add(this.btnMB);
            this.Name = "DialogBox";
            this.Text = "DialogBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMB;
        private System.Windows.Forms.Label lblYes;
        private System.Windows.Forms.Label lblNo;
    }
}