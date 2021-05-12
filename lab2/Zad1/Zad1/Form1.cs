using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Podaj wzrost!");
            }
            else
            {
                string standard_height = Convert.ToString(Convert.ToDouble(textBox1.Text) - 100);
                if (checkBox1.Checked)
                {
                    result.Text = "Wynik: " + standard_height;
                }
                else if (checkBox2.Checked)
                {
                    if (rdoWomen.Checked)
                    {
                        result.Text = "Wynik: " + Convert.ToString(Convert.ToDouble(standard_height) * 0.85);
                    }
                    else if (rdoMen.Checked)
                    {
                        result.Text = "Wynik: " + Convert.ToString(Convert.ToDouble(standard_height) * 0.9);
                    }
                    else
                    {
                        MessageBox.Show("Wybierz płeć!");
                    }
                }
                else
                {
                    MessageBox.Show("Wybierz wage!");
                }
            }
        }
    }
}
