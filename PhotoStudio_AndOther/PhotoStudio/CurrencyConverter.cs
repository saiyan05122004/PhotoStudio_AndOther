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
    public partial class CurrencyConverter : Form
    {
        string from_wallet = "";
        string to_wallet = "";

        public CurrencyConverter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            float from = Convert.ToInt32(textBox1.Text);
            float currency = 0;
            float result = 0;

            if (from_wallet == "RUR") currency = (float)(from / 74.56);
            else if (from_wallet == "USD") currency = (float)(from / 1.05);
            else if (from_wallet == "EUR") currency = from;

            if (to_wallet == "RUR") result = (float)(currency * 74.56);
            else if (to_wallet == "USD") result = (float)(currency * 1.05);
            else if (to_wallet == "EUR") result = currency;

            textBox2.Text = result.ToString();
        }

        private void from_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            button1.BackColor = Button.DefaultBackColor;
            button2.BackColor = Button.DefaultBackColor;
            button3.BackColor = Button.DefaultBackColor;

            button.BackColor = Color.DodgerBlue;

            from_wallet = button.Text;
        }

        private void to_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            button4.BackColor = Button.DefaultBackColor;
            button5.BackColor = Button.DefaultBackColor;
            button6.BackColor = Button.DefaultBackColor;

            button.BackColor = Color.DodgerBlue;

            to_wallet = button.Text;
        }
    }
}
