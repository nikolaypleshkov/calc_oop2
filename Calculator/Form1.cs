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
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
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
            label1.Text += "=";
            richTextBox1.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            input += button5.Text;
            label1.Text += button5.Text;
            richTextBox1.Text = input;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = " ";
            input += button6.Text;
            label1.Text += button6.Text;
            richTextBox1.Text = input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            input += button7.Text;
            label1.Text += button7.Text;
            richTextBox1.Text = input;
        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            input += button9.Text;
            label1.Text += button9.Text;
            richTextBox1.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            input += button10.Text;
            label1.Text += button10.Text;
            richTextBox1.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            input += button11.Text;
            label1.Text += button11.Text;
            richTextBox1.Text += input;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            input += button13.Text;
            label1.Text += button13.Text;
            richTextBox1.Text += input;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            input += button14.Text;
            label1.Text += button14.Text;
            richTextBox1.Text += input;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            input += button15.Text;
            label1.Text += button15.Text;
            richTextBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            input += button2.Text;
            label1.Text += button2.Text;
            richTextBox1.Text += input; 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            label1.Text += '+'; 
            input = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }
    }
}
