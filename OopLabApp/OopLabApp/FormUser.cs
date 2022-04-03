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

<<<<<<< HEAD
        private void FormUser_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

=======

        private void Userlogin_Click(object sender, EventArgs e)
        {
            if (Usertxt.Text == "user" && Userpsw.Text == "user")
            {
                OyunPenceresi oyunPenceresi = new OyunPenceresi();
                oyunPenceresi.Show(); //Oyunpenceresini göster.
                this.Hide(); //Formuseri sakla.
            }
           else if (Usertxt.Text == "" || Userpsw.Text == "")
            {
                string message = "Belirli alanlar boş bırakılamaz";
                string title = "Hata";
                MessageBox.Show(message, title);
            }
            else
            {
                string message = "Kullanıcı adı veya parola hatalı";
                string title = "Hata";
                MessageBox.Show(message, title);
            }
>>>>>>> main
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
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
=======
        private void Usertxt_TextChanged(object sender, EventArgs e)
        {
            Usertxt.Select();
            this.AcceptButton = Userlogin; //userform'da username textbox'inda enter tusu ile login yapma
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            Usertxt.Focus(); //user login ekrani ilk acildiginda username textbox'ina focus ol
        }

        private void Userpsw_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = Userlogin; //userform'da password textbox'inda enter tusu ile login yapma
>>>>>>> main
        }
    }
}
