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
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float d = Convert.ToInt32(textBox1.Text);
            float price = 0;

            if (radioButton1.Checked) price = d * 50 + 700;
            else if (radioButton2.Checked) price = d * 50;

            label2.Text = "Оплата, руб " + price;
        }
    }
}
