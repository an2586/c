using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string at;
        public string bt;
        public string ct;
        public string dt;
        public string et;
        public string ft;
        public string gt;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Random numer = new Random();
            int a = numer.Next(1, 5);
            at = a.ToString();
            textBox1.Text += at + ", ";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Random numer = new Random();
            int b = numer.Next(1, 7);
            bt = b.ToString();
            textBox1.Text += bt + ", ";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Random numer = new Random();
            int c = numer.Next(1, 9);
            ct = c.ToString();
            textBox1.Text += ct + ", ";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Random numer = new Random();
            int d = numer.Next(1, 11);
            dt = d.ToString();
            textBox1.Text += dt + ", ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random numer = new Random();
            int ee = numer.Next(1, 13);
            et = ee.ToString();
            textBox1.Text += et + ", ";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Random numer = new Random();
            int f = numer.Next(1, 21);
            ft = f.ToString();
            textBox1.Text += ft + ", ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random numer = new Random();
            int g = numer.Next(1, 101);
            gt = g.ToString();
            textBox1.Text += gt + ", ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
