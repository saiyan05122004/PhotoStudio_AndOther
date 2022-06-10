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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = 0;
            if (radioButton1.Checked) price = 12;
            else if (radioButton2.Checked) price = 24;
            else if (radioButton3.Checked) price = 59;

            int count = Convert.ToInt32(textBox1.Text);
            label2.Text = "К оплате: " + (count * price).ToString();
        }
    }
}
