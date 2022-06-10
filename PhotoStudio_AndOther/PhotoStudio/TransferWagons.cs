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
    public partial class TransferWagons : Form
    {
        public TransferWagons()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int VasilySeat = Convert.ToInt32(textBox3.Text); // Место Василия
            int PetrSeat = Convert.ToInt32(textBox2.Text); // Место Петра
            int SeatsCount = Convert.ToInt32(textBox1.Text); // кол-во мест в вагоне

            int VasilyVan = VasilySeat / SeatsCount + 1; // Вагон Василия
            int PetrVan = PetrSeat / SeatsCount + 1; // Вагон Петра

            label6.Text = "Пётр должен пройти до встречи с Петром " + Math.Abs(VasilyVan - PetrVan).ToString() + " вагонов";
            label4.Text = "Номер вагона Петра:\n" + VasilyVan.ToString();
            label5.Text = "Номер вагона Василия:\n" + PetrVan.ToString();
        }
    }
}
