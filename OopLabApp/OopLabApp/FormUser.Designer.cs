
namespace OopLabApp
{
    partial class FormUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.Userpsw = new System.Windows.Forms.TextBox();
            this.Userlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(170, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(170, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // Usertxt
            // 
            this.Usertxt.Location = new System.Drawing.Point(306, 112);
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(212, 22);
            this.Usertxt.TabIndex = 7;
            // 
            // Userpsw
            // 
            this.Userpsw.Location = new System.Drawing.Point(306, 162);
            this.Userpsw.Name = "Userpsw";
            this.Userpsw.PasswordChar = '*';
            this.Userpsw.Size = new System.Drawing.Size(212, 22);
            this.Userpsw.TabIndex = 6;
            // 
            // Userlogin
            // 
            this.Userlogin.Location = new System.Drawing.Point(306, 223);
            this.Userlogin.Name = "Userlogin";
            this.Userlogin.Size = new System.Drawing.Size(212, 93);
            this.Userlogin.TabIndex = 10;
            this.Userlogin.Text = "Login";
            this.Userlogin.UseVisualStyleBackColor = true;
            this.Userlogin.Click += new System.EventHandler(this.Userlogin_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Userlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Usertxt);
            this.Controls.Add(this.Userpsw);
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUser_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.TextBox Userpsw;
        private System.Windows.Forms.Button Userlogin;
    }
}