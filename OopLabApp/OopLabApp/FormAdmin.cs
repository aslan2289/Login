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

        private void Admintxt_TextChanged(object sender, EventArgs e)
        {
            Admintxt.Focus();
        }

        private void Adminpsw_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
