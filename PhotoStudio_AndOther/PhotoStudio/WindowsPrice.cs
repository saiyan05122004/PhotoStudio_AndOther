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
    public partial class WindowsPrice : Form
    {
        public WindowsPrice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float h = Convert.ToInt32(textBox1.Text);
            float w = Convert.ToInt32(textBox2.Text);
            float price = (w / 100 * h / 100) * 5;

            if (comboBox1.SelectedIndex == 0) price += 1000;
            else if (comboBox1.SelectedIndex == 1) price += 1500;
            else MessageBox.Show("Выберите три механизма", "Внимание");

            if (checkBox1.Checked) price += 300;
            if (checkBox2.Checked) price += 2000;
            if (checkBox3.Checked) price += 500;

            label5.Text = "Цена: " + price;
        }
    }
}
