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
    public partial class Oyna : Form
    {
        private void Matrix9x9()
        {
            int sayac = 1;
            for(int i=0;i<9;i++)
            {
                for (int j = 0; j < 9;j++)
                {
                    sayac++;
                    Button btn = new Button();
                    btn.Name = "btn-"+sayac;
                    btn.Text = "";
                    btn.Size = new Size(50, 30);
                    btn.Location = new Point(10 + 55 * j, 10 + 35 * i);
                    this.Controls.Add(btn);
                    
                 }
            }
        }

        private void Renk()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 82);
            this.Text = sayi.ToString();

        }



        public Oyna()
        {
            InitializeComponent();
        }

        private void Oyna_Load(object sender, EventArgs e)
        {
            Matrix9x9();
            Renk();

        }

        private void Oyna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
