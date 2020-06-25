using System;

namespace Assignment_2___Chapter_12_Programming_Exercises
{
    partial class Form1
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
            this.dpt = new System.Windows.Forms.Button();
            this.wth = new System.Windows.Forms.Button();
            this.bal = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dpt
            // 
            this.dpt.Location = new System.Drawing.Point(214, 238);
            this.dpt.Name = "dpt";
            this.dpt.Size = new System.Drawing.Size(75, 23);
            this.dpt.TabIndex = 0;
            this.dpt.Text = "Deposit";
            this.dpt.UseVisualStyleBackColor = true;
            this.dpt.Click += new System.EventHandler(this.dpt_Click);
            // 
            // wth
            // 
            this.wth.Location = new System.Drawing.Point(348, 238);
            this.wth.Name = "wth";
            this.wth.Size = new System.Drawing.Size(75, 23);
            this.wth.TabIndex = 1;
            this.wth.Text = "Withdraw";
            this.wth.UseVisualStyleBackColor = true;
            this.wth.Click += new System.EventHandler(this.wth_Click);
            // 
            // bal
            // 
            this.bal.Location = new System.Drawing.Point(479, 238);
            this.bal.Name = "bal";
            this.bal.Size = new System.Drawing.Size(75, 23);
            this.bal.TabIndex = 2;
            this.bal.Text = "Balence";
            this.bal.UseVisualStyleBackColor = true;
            this.bal.Click += new System.EventHandler(this.bal_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 69);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bal);
            this.Controls.Add(this.wth);
            this.Controls.Add(this.dpt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void bal_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void wth_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button dpt;
        private System.Windows.Forms.Button wth;
        private System.Windows.Forms.Button bal;
        private System.Windows.Forms.TextBox textBox1;
    }
}

