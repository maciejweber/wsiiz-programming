using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // WIELKOŚĆ
            if (radioButton1.Checked)
            {
                textBox1.Font = new System.Drawing.Font(textBox1.Font.FontFamily, 8F);
            }
            if (radioButton2.Checked)
            {
                textBox1.Font = new System.Drawing.Font(textBox1.Font.FontFamily, 16F);
            }
            if (radioButton3.Checked)
            {
                textBox1.Font = new System.Drawing.Font(textBox1.Font.FontFamily, 24F);
            }

            // STYL CZCIONKI
            if (radioButton4.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            }
            if (radioButton5.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
            if (radioButton6.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
            }

            // KOLOR CZCIONKI
            if (radioButton7.Checked)
            {
                textBox1.ForeColor = System.Drawing.Color.Red;
            }
            if (radioButton8.Checked)
            {
                textBox1.ForeColor = System.Drawing.Color.Blue;
            }
            if (radioButton9.Checked)
            {
                textBox1.ForeColor = System.Drawing.Color.Orange;
            }
        }
    }
}
