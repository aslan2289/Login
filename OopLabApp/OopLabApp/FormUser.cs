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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Usertxt_TextChanged(object sender, EventArgs e)
        {
            Usertxt.Select();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            Usertxt.Focus();
        }
    }
}
