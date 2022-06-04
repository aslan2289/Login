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


    public partial class Oyunuoyna : Form
    {
        List<Button> buttons = new List<Button>();
        int yatay, dikey, size; //   custom ise kendi ayarlıcak size 'ı
        string kare = "", daire = "", ucgen = "", kırmızı = "", mavi = "", siyah = "";


        public Oyunuoyna()
        {
            InitializeComponent();
        }

        private void Oyunuoyna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


       // int sayac = 0;
        public void ButonMatris()
        {
            for (int i=0;i</*yatay*/9;i++)
            {
                for (int j=0;j</*dikey*/9;j++)
                {
                    Button button = new Button();
                    button.Width = 50;
                    button.Height = 50;
                    button.Location = new Point(/*yatay*/90*i, /*dikey*/90 * j);
                    buttons.Add(button);
                }
            }

        }

        public void butonyazdir()
        {
            foreach (Button button in buttons)
            {
                this.Controls.Add(button);
            }
        }

        public void butonrenk()
        {
            foreach(Button button in buttons)
            {
               
            }
                 
        }

        public void butonsekil()
        {

        }

    

        private void Oyunuoyna_Load(object sender, EventArgs e)
        {
            
        }

        private void Olusturbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void Oyunuoyna_Load_1(object sender, EventArgs e)
        {
            ButonMatris();
            butonyazdir();
        }
    }
}
