using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(textBox1.Text);
                textBox2.Text = (x * x).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Podano błędne dane", "Uwaga!", MessageBoxButtons.OK);
            }
        }
    }
}
