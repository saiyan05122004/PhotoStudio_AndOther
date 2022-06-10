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
    public partial class Gas : Form
    {
        public Gas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float k = Convert.ToInt32(textBox1.Text);
            float l = Convert.ToInt32(textBox2.Text);

            float r = k / 100 * l;

            label4.Text = r.ToString() + " л/100 км";
        }
    }
}
