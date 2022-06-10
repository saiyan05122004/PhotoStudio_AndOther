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
    public partial class PhotoStudio : Form
    {
        public PhotoStudio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(textBox1.Text);
            int price = 0;

            if (comboBox1.SelectedIndex == 0) price = 12;
            else if (comboBox1.SelectedIndex == 1) price = 24;
            else if (comboBox1.SelectedIndex == 2) price = 59;
            
            label3.Text = "Цена: " + (price * count).ToString();
        }
    }
}
