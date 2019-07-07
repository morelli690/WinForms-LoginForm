namespace Login
{
    partial class Radio
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
            this.radioHtml = new System.Windows.Forms.RadioButton();
            this.radioCss = new System.Windows.Forms.RadioButton();
            this.radioCsharp = new System.Windows.Forms.RadioButton();
            this.radioCplusplus = new System.Windows.Forms.RadioButton();
            this.radioJava = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioHtml
            // 
            this.radioHtml.AutoSize = true;
            this.radioHtml.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHtml.Location = new System.Drawing.Point(317, 134);
            this.radioHtml.Name = "radioHtml";
            this.radioHtml.Size = new System.Drawing.Size(75, 30);
            this.radioHtml.TabIndex = 0;
            this.radioHtml.TabStop = true;
            this.radioHtml.Text = "html";
            this.radioHtml.UseVisualStyleBackColor = true;
            // 
            // radioCss
            // 
            this.radioCss.AutoSize = true;
            this.radioCss.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCss.Location = new System.Drawing.Point(317, 170);
            this.radioCss.Name = "radioCss";
            this.radioCss.Size = new System.Drawing.Size(65, 30);
            this.radioCss.TabIndex = 1;
            this.radioCss.TabStop = true;
            this.radioCss.Text = "CSS";
            this.radioCss.UseVisualStyleBackColor = true;
            // 
            // radioCsharp
            // 
            this.radioCsharp.AutoSize = true;
            this.radioCsharp.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCsharp.Location = new System.Drawing.Point(317, 206);
            this.radioCsharp.Name = "radioCsharp";
            this.radioCsharp.Size = new System.Drawing.Size(55, 30);
            this.radioCsharp.TabIndex = 2;
            this.radioCsharp.TabStop = true;
            this.radioCsharp.Text = "C#";
            this.radioCsharp.UseVisualStyleBackColor = true;
            // 
            // radioCplusplus
            // 
            this.radioCplusplus.AutoSize = true;
            this.radioCplusplus.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCplusplus.Location = new System.Drawing.Point(317, 242);
            this.radioCplusplus.Name = "radioCplusplus";
            this.radioCplusplus.Size = new System.Drawing.Size(71, 30);
            this.radioCplusplus.TabIndex = 3;
            this.radioCplusplus.TabStop = true;
            this.radioCplusplus.Text = "C++";
            this.radioCplusplus.UseVisualStyleBackColor = true;
            // 
            // radioJava
            // 
            this.radioJava.AutoSize = true;
            this.radioJava.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioJava.Location = new System.Drawing.Point(317, 278);
            this.radioJava.Name = "radioJava";
            this.radioJava.Size = new System.Drawing.Size(72, 30);
            this.radioJava.TabIndex = 4;
            this.radioJava.TabStop = true;
            this.radioJava.Text = "Java";
            this.radioJava.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.AutoSize = true;
            this.btnShow.BackColor = System.Drawing.Color.Green;
            this.btnShow.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(491, 359);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 36);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Which is the best?";
            // 
            // Radio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.radioJava);
            this.Controls.Add(this.radioCplusplus);
            this.Controls.Add(this.radioCsharp);
            this.Controls.Add(this.radioCss);
            this.Controls.Add(this.radioHtml);
            this.Name = "Radio";
            this.Text = "Radio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioHtml;
        private System.Windows.Forms.RadioButton radioCss;
        private System.Windows.Forms.RadioButton radioCsharp;
        private System.Windows.Forms.RadioButton radioCplusplus;
        private System.Windows.Forms.RadioButton radioJava;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label1;
    }
}