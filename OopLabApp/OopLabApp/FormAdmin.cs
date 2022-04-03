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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void Adminlgn_Click(object sender, EventArgs e)
        {
            if(Admintxt.Text=="admin" && Adminpsw.Text=="admin")
            {
                OyunPenceresi oyunPenceresi = new OyunPenceresi();
                oyunPenceresi.Show(); //Oyunpenceresini göster
                this.Hide(); //FormAdmini gizle
            }
            else if(Admintxt.Text=="" || Adminpsw.Text=="")
            {
                string message = "Belirli alanlar boş bırakılamaz";
                string title = "Hata";
                MessageBox.Show(message,title);
            }
            else
            {
                string message = "Kullanıcı adı veya parola hatalı";
                string title = "Hata";
                MessageBox.Show(message, title);
            }

        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

<<<<<<< HEAD
        private void label1_Click(object sender, EventArgs e)
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
            if(user=="admin" && pass == "admin")
            {
                FormGame formGame = new FormGame(); 
                formGame.Show(); //FormGame'i goster
                this.Hide(); // FormAdmin'i gizle
                
            }
            //eger istenilen text disinda text girilirse bir message box ile hata mesaji goster
            else
            {
                MessageBox.Show("Username or passwords is incorrect!");
            }
        }
=======
        private void Admintxt_TextChanged(object sender, EventArgs e)
        {
            Admintxt.Focus(); //admin login penceresi acildiginda username textbox'ina focus ol
            this.AcceptButton = Adminlgn; //adminform'da username textbox'inda enter tusu ile login yapma
        }

        private void Adminpsw_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = Adminlgn; //adminform'da password textbox'inda enter tusu ile login yapma
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
>>>>>>> main
    }
}
