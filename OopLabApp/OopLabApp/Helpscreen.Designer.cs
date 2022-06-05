
namespace OopLabApp
{
    partial class Helpscreen
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
            this.helptxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Aboutbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helptxt
            // 
            this.helptxt.Location = new System.Drawing.Point(117, 12);
            this.helptxt.Multiline = true;
            this.helptxt.Name = "helptxt";
            this.helptxt.Size = new System.Drawing.Size(671, 100);
            this.helptxt.TabIndex = 0;
            this.helptxt.Text = "If a shape is moved to the left for three boxes, the shape will \r\nmove one step t" +
    "o the right, one step to the right, and again one step to the \r\nright at interva" +
    "ls of one second.";
            this.helptxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usage";
            // 
            // Aboutbtn
            // 
            this.Aboutbtn.Location = new System.Drawing.Point(117, 143);
            this.Aboutbtn.Name = "Aboutbtn";
            this.Aboutbtn.Size = new System.Drawing.Size(141, 62);
            this.Aboutbtn.TabIndex = 2;
            this.Aboutbtn.Text = "About";
            this.Aboutbtn.UseVisualStyleBackColor = true;
            // 
            // Helpscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Aboutbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helptxt);
            this.Name = "Helpscreen";
            this.Text = "Helpscreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Helpscreen_FormClosing);
            this.Load += new System.EventHandler(this.Helpscreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox helptxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Aboutbtn;
    }
}