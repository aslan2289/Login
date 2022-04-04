﻿using System;
using System.IO;
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
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
            this.TopMost = true;
        }

       

        private void RenkSec_Click(object sender, EventArgs e)
        {
            

            TextWriter textWriter = new StreamWriter("./save.txt");

            if(sarıcheck.Checked==true)
            {
                textWriter.WriteLine("Sarı");
            }
            if (kırmızıcheck.Checked == true)
            {
                textWriter.WriteLine("Kırmızı");
            }
            if (Morcheck.Checked == true)
            {
                textWriter.WriteLine("Mor");
            }
            textWriter.Close();


        }
        private void Ayarlar_Load(object sender, EventArgs e)
        {
            string text = File.ReadAllText("./save.txt");


            if (text.Contains("Kırmızı"))
            {
                kırmızıcheck.Checked = true;
            }
            if (text.Contains("Sarı"))
            {
                sarıcheck.Checked = true;
            }
            if (text.Contains("Mor"))
            {
                Morcheck.Checked = true;
            }

        }

        private void sarıcheck_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void kırmızıcheck_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Morcheck_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Ayarlar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CustomCol_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CustomRow_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CustomRow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            
        }

        private void CustomCol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            
        }
    }
}