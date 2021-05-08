using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private const string V = "+";
        bool expresion = false;
        string num2 = string.Empty;
        string _operation;
        double _input = 0;

        double _memory = 0;
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
            switch (_operation)
            {
                case "+": 
                    richTextBox1.Text = (_input + Double.Parse(richTextBox1.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "-":
                    richTextBox1.Text = (_input - Double.Parse(richTextBox1.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "X":
                    richTextBox1.Text = (_input * Double.Parse(richTextBox1.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "÷":
                    richTextBox1.Text = (_input / Double.Parse(richTextBox1.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                default:
                    Console.WriteLine("Nothing");
                    break;
            }
            _input = Double.Parse(richTextBox1.Text);
            _operation = "";

        }


        private void button29_Click(object sender, EventArgs e)
        {
            _memory -= Double.Parse(richTextBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.Text.Contains("."))
            {
               richTextBox1.Text += ".";
            }
           
        }

        private void button22_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            label1.Text = " ";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
        }

        private void operation(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(_input != 0)
            {
                button4.PerformClick();
                expresion = true;
                _operation = btn.Text;
                label1.Text = _input + "  " + _operation;
            }
            else
            {
                _operation = btn.Text;
                _input = Double.Parse(richTextBox1.Text, CultureInfo.InvariantCulture);
                expresion = true;
                label1.Text = _input + "  " + _operation;
            }

        }

        private void button21_Click(object sender, EventArgs e)
        {
            double percent;
            percent = Convert.ToDouble(richTextBox1.Text, CultureInfo.InvariantCulture) / Convert.ToDouble(100);
            richTextBox1.Text = Convert.ToString(percent);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double sqrt;
            label1.Text = "Sqrt(" + richTextBox1.Text + ")";
            sqrt = Math.Sqrt(Double.Parse(richTextBox1.Text));
            richTextBox1.Text = Convert.ToString(sqrt);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double x2;
            x2 = Convert.ToDouble(richTextBox1.Text, CultureInfo.InvariantCulture) * Convert.ToDouble(richTextBox1.Text, CultureInfo.InvariantCulture);
            richTextBox1.Text = Convert.ToString(x2);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double x1;
            x1 = Convert.ToDouble(1.0 / Convert.ToDouble(richTextBox1.Text, CultureInfo.InvariantCulture));
            richTextBox1.Text = Convert.ToString(x1);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text.Length > 0)
            {
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1, 1);
            }
            if(richTextBox1.Text == "")
            {
                richTextBox1.Text = "0";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            label1.Text = " ";
            _memory = 0;
            button26.Enabled = false;
            button25.Enabled = false;

        }

        private void button26_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = _memory.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            _memory += Double.Parse(richTextBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(richTextBox1.Text == "0" || expresion)
            {
                label1.Text +=" " + btn.Text+" ";
                richTextBox1.Text = btn.Text;
                expresion = false;
            }
            else
            {
                richTextBox1.Text = " ";
                richTextBox1.Text += btn.Text;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text.StartsWith("-"))
            {
                richTextBox1.Text = richTextBox1.Text.Substring(1);
            }
            else if(!string.IsNullOrEmpty(richTextBox1.Text) && Double.Parse(richTextBox1.Text) != 0)
            {
                richTextBox1.Text = "-"+richTextBox1.Text;
            }
            
        }
    }
}
