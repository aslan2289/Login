using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OopLabApp
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //login butonu
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //username ve password stringleri tanımlama
            string user, pass;
            user = txtUser.Text;
            pass = txtPassword.Text;

            //username ve password'un istenilen textleri karsilayip karsilamadigini kontrol etme  
            if (user=="user"&& pass=="user")
            {
                FormGame formGame = new FormGame();
                formGame.Show(); //FormGame'i goster
                this.Hide(); //FormUser'i gizle
            }

            //eger istenilen text disinda text girilirse bir message box ile hata mesaji goster
            else
            {
                MessageBox.Show("Username or password is incorrect!");
            }
        }
    }
}
