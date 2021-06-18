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
    public partial class Words : Form
    {
        public Words()
        {
            InitializeComponent();
        }

        private void objectbackButton_Click(object sender, EventArgs e)
        {
            Form1 a2 = new Form1();
            a2.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
