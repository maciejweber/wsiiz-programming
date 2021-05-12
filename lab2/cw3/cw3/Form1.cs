using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw3
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else MessageBox.Show("Aby dodac najpierw zaznacz element!");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
            else MessageBox.Show("Aby usunac najpierw zaznacz element!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
