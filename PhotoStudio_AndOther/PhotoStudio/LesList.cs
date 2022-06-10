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
    public partial class LesList : Form
    {
        string login;
        public LesList(string Login)
        {
            login = Login;
            InitializeComponent();
        }

        private void Next_Load(object sender, EventArgs e)
        {
            label1.Text = login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Les1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Les2().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Les3().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Les4().Show();
        }
    }
}
