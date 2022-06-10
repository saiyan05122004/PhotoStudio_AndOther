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
    public partial class BuyCar : Form
    {
        public BuyCar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string price = "";
            if (radioButton1.Checked)
            {
                price = "$128,440";
                pictureBox1.Image = Properties.Resources.PearlWhiteMulti_Coat;
            }
            else if (radioButton2.Checked)
            {
                price = "$129,940";
                pictureBox1.Image = Properties.Resources.DeepBlueMetallic;
            }
            else if (radioButton3.Checked)
            {
                price = "$130,940";
                pictureBox1.Image = Properties.Resources.RedMulti_Coat;
            }
            label2.Text = "Цена в выбранном цвете: " + price;
        }
    }
}
