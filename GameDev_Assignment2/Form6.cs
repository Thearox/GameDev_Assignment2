using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDev_Assignment2
{
    public partial class Form6 : Form
    {
        List<Panel> gamePanel = new List<Panel>();
        int i;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.MouseClick);
            splayer.Play();
            Form4 a2 = new Form4();
            a2.Show();
            this.Hide();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            gamePanel.Add(panel1);
            gamePanel.Add(panel2);
            gamePanel.Add(panel3);
            gamePanel.Add(panel4);
            gamePanel.Add(panel5);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void gameImgChk1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Piesang")
            {
                MessageBox.Show("Correct!");
                panel1.SendToBack();
                panel2.Show();
                panel2.BringToFront();
            }
            else
            {
                MessageBox.Show("Incorrect");
            }
        }

        private void gameImgChk2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Olifant")
            {
                MessageBox.Show("Correct!");
                panel2.SendToBack();
                panel3.Show();
                panel3.BringToFront();
            }
            else
            {
                MessageBox.Show("Incorrect");
            }
        }

        private void gameImgChk3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Twee")
            {
                MessageBox.Show("Correct!");
                panel3.SendToBack();
                panel4.Show();
                panel4.BringToFront();
            }
            else
            {
                MessageBox.Show("Incorrect");
            }
        }

        private void gameImgChk4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "Blou Huis")
            {
                MessageBox.Show("Correct!");
                panel4.SendToBack();
                panel5.Show();
                panel5.BringToFront();
            }
            else
            {
                MessageBox.Show("Incorrect");
            }
        }

        private void gameImgChk5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "Rooi Kar")
            {
                MessageBox.Show("Correct!");
                Form4 f4 = new Form4();
                f4.Show();
                Visible = false;

            }
            else
            {
                MessageBox.Show("Incorrect");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
