using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cw4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                label2.Text = "Twój ulubiony samochód to: " + comboBox1.SelectedItem.ToString();
            } 
            else
            {
                MessageBox.Show("Nie wybrałeś samochodu z listy!");
            }
        }
    }
}
