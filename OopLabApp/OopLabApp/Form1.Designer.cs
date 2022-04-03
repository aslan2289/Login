
namespace OopLabApp
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
            this.Adminbtn = new System.Windows.Forms.Button();
            this.Userbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Adminbtn
            // 
            this.Adminbtn.Location = new System.Drawing.Point(397, 88);
            this.Adminbtn.Name = "Adminbtn";
            this.Adminbtn.Size = new System.Drawing.Size(242, 169);
            this.Adminbtn.TabIndex = 0;
            this.Adminbtn.Text = "Admin";
            this.Adminbtn.UseVisualStyleBackColor = true;
            this.Adminbtn.Click += new System.EventHandler(this.Adminbtn_Click);
            // 
            // Userbtn
            // 
            this.Userbtn.Location = new System.Drawing.Point(106, 88);
            this.Userbtn.Name = "Userbtn";
            this.Userbtn.Size = new System.Drawing.Size(242, 169);
            this.Userbtn.TabIndex = 1;
            this.Userbtn.Text = "User";
            this.Userbtn.UseVisualStyleBackColor = true;
            this.Userbtn.Click += new System.EventHandler(this.Userbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 402);
            this.Controls.Add(this.Userbtn);
            this.Controls.Add(this.Adminbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Adminbtn;
        private System.Windows.Forms.Button Userbtn;
    }
}