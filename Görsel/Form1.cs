using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görsel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox1.Text;
            int şifre = Convert.ToInt32(textBox2.Text);
            if (kullaniciadi== "ali"  && şifre == 1256)
            {
                label3.Text = "Doğru";
            }
            else
            {
                label3.Text = "Yanlış";
            }
        }
    }
}
