using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_4
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
                float x = float.Parse(textBoxX.Text);
                float y = float.Parse(textBoxY.Text);
                float z = float.Parse(textBoxZ.Text);
                textBoxWynik.Text = (x + y + z).ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Podano błędne dane", "Uwaga!", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(textBoxX.Text);
                float y = float.Parse(textBoxY.Text);
                float z = float.Parse(textBoxZ.Text);
                textBoxWynik.Text = (x * y * z).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Podano błędne dane", "Uwaga!", MessageBoxButtons.OK);
            }
        }
    }
}
