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
    public partial class Helpscreen : Form
    {
        public Helpscreen()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void Helpscreen_Load(object sender, EventArgs e)
        {

        }

        private void Helpscreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
