using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string num1 = string.Empty;
        string num2 = string.Empty;
        char operation;
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;

        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;

        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;

        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;

        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;

        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;

        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void button10_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;

        }

        private void button11_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            input += ",";
            this.textBox1.Text += input;
        }

        private void button16_MouseClick(object sender, MouseEventArgs e)
        {
            num1 = input;
            operation = Convert.ToChar("/");
            input = string.Empty;
        }

        private void button15_MouseClick(object sender, MouseEventArgs e)
        {
            num1 = input;
            operation = Convert.ToChar("*");
            input = string.Empty;
        }

        private void button14_MouseClick(object sender, MouseEventArgs e)
        {
            num1 = input;
            operation = Convert.ToChar("-");
            input = string.Empty;
        }

        private void button13_MouseClick(object sender, MouseEventArgs e)
        {
            num1 = input;
            operation = Convert.ToChar("+");
            input = string.Empty;
        }

        private void button17_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.num1 = string.Empty;
            this.num2 = string.Empty;
        }
        private void button12_MouseClick(object sender, MouseEventArgs e)
        {
            num2 = input;
            double finNum1, finNum2;
            double.TryParse(num1, out finNum1);
            double.TryParse(num2, out finNum2);

            if (operation == Convert.ToChar("+"))
            {
                result = finNum1 + finNum2;
                textBox1.Text = result.ToString();

            }
            else if (operation == Convert.ToChar("-"))
            {
                result = finNum1 - finNum2;
                textBox1.Text = result.ToString();

            }
            else if (operation == Convert.ToChar("*"))
            {
                result = finNum1 * finNum2;
                textBox1.Text = result.ToString();

            }
            else if (operation == Convert.ToChar("/"))
            {
                if (finNum2 != 0)
                {
                    result = finNum1 / finNum2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "cannot divide by 0";
                }
            }
        }
    }
}
