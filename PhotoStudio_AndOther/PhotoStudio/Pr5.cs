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
    public partial class Pr5 : Form
    {
        public Pr5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (textBox1.Text != "") c = Convert.ToInt32(textBox1.Text) - 50;
            else
            {
                textBox1.Text = "50";
            }

            if (c >= 50)
            {
                label1.Text = c.ToString() + "$";
                textBox1.Text = c.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (textBox1.Text != "") c = Convert.ToInt32(textBox1.Text) + 50;
            else
            {
                textBox1.Text = "50";
                c = 100;
            }

            if (c >= 50)
            {
                label1.Text = c.ToString() + "$";
                textBox1.Text = c.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Form1();
            form.Show();
        }
    }
}
