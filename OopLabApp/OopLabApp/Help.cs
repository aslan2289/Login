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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
           
        }

        private void Aboutttbtn_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
            // this.Hide();
            // this.Enabled = false;
        }

        private void Help_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Help_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            
        }
    }
}
