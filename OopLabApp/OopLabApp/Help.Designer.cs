
namespace OopLabApp
{
    partial class Help
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Aboutttbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usage";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 90);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "e: If a shape is moved to the left for three boxes, the shape will \r\nmove one ste" +
    "p to the right, one step to the right, and again one step to the \r\nright at inte" +
    "rvals of one second. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Game tools";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(224, 180);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(353, 90);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Circle,Square,Triangle";
            // 
            // Aboutttbtn
            // 
            this.Aboutttbtn.Location = new System.Drawing.Point(317, 300);
            this.Aboutttbtn.Name = "Aboutttbtn";
            this.Aboutttbtn.Size = new System.Drawing.Size(75, 23);
            this.Aboutttbtn.TabIndex = 4;
            this.Aboutttbtn.Text = "About";
            this.Aboutttbtn.UseVisualStyleBackColor = true;
            this.Aboutttbtn.Click += new System.EventHandler(this.Aboutttbtn_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Aboutttbtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Help";
            this.Text = "Help";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Help_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Help_FormClosed);
            this.Load += new System.EventHandler(this.Help_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Aboutttbtn;
    }
}