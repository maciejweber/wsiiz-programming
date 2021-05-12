using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string sColor = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdoRed.Checked) 
            {
                sColor = rdoRed.Text;
            }
            if (rdoGreen.Checked)
            {
                sColor = rdoGreen.Text;
            }
            if (rdoBlue.Checked)
            {
                sColor = rdoBlue.Text;
            }
            MessageBox.Show("Twoj ulubiony kolor to : " + sColor);
        }
    }
}
