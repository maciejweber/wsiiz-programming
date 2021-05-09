using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_5
{
    public partial class Form1 : Form
    {
        string sign;
        double num1;
        double num2;
        bool startNewNumber = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberButton("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberButton("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumberButton("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumberButton("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumberButton("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumberButton("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumberButton("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NumberButton("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumberButton("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            NumberButton("0");
        }

        private void NumberButton(string number)
        {
            if (startNewNumber == false)
            {
                textBox1.Text += number;
            } else
            {
                textBox1.Text = number;
                startNewNumber = false;
            }
        }

        private void Operation(string sign)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            this.sign = sign;
            startNewNumber = true;

        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            switch (sign)
            {
                case "+":
                    textBox1.Text = Convert.ToString(num1 + num2);
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(num1 - num2);
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(num1 * num2);
                    break;
                case "/":
                    if(num1 == 0 | num2 == 0)
                    {
                        MessageBox.Show("Nie dziel przez 0", "Error", MessageBoxButtons.OK);
                    } else
                    {
                        textBox1.Text = Convert.ToString(num1 / num2);
                    }
                    break;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Operation("+");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Operation("-");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Operation("*");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            Operation("/");
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.IndexOf(",") == -1)
            {
                textBox1.Text += ",";
                startNewNumber = false;
            }
        }
    }
}
