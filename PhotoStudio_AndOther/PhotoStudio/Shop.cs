using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoStudio_Selin
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int count = Convert.ToInt32(textBox1.Text);
            if (comboBox1.SelectedIndex == 0) sum = 300 * count;
            else if (comboBox1.SelectedIndex == 1) sum = 500 * count;
            else if (comboBox1.SelectedIndex == 2) sum = 700 * count;

            label3.Text = "Цена: " + sum.ToString();
        }
    }
}
