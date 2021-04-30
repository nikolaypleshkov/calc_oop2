using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.RightToLeft = RightToLeft.Yes;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = richTextBox1.Text + "=";
            richTextBox1.Text = "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button7.Text;
        }
    }
}
