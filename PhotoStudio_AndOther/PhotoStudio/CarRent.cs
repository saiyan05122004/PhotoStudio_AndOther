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
    public partial class CarRent : Form
    {
        public CarRent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float h = Convert.ToInt32(textBox1.Text);
            float price = 0;

            if (radioButton1.Checked) price = h * 1500;
            else if (radioButton2.Checked) price = h * 800;
            else if (radioButton3.Checked) price = h * 3000;

            label2.Text = "Оплата: " + price;
        }
    }
}
