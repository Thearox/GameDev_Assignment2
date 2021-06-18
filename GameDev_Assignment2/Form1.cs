using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDev_Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alphabet a2 = new Alphabet();
            a2.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Words a2 = new Words();
            a2.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
