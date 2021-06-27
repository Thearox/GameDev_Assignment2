using System;
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

    public partial class Form5 : Form
    {
        List<Panel> panel = new List<Panel>();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            panel.Add(panel1);
            panel.Add(panel2);
            panel.Add(panel3);
            panel.Add(panel4);
            //panel.Add(panel5);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "o" && textBox9.Text == "d")
            {
                MessageBox.Show("Mond is correct !");
                panel6.SendToBack();
                panel2.Show();
                panel2.BringToFront();
            }
            else
            {
                MessageBox.Show("Incorrect");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "u" && textBox4.Text == "s")
            {
                MessageBox.Show("Neus is correct");
                panel2.SendToBack();
                panel3.Show();
                panel3.BringToFront();
            }
            else
            {
                MessageBox.Show("Incorrect");
            }

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (textBox6.Text == "e" && textBox5.Text == "r")
            {
                MessageBox.Show("Pers is correct !");
                panel3.SendToBack();
                panel1.Show();
                panel1.BringToFront();

            }
            else
            {
                MessageBox.Show("Incorrect");
            }
        }

       
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "V" && textBox2.Text == "e")
            {
                MessageBox.Show("Voet is correct !");
                panel1.SendToBack();
                panel4.Show();
                panel4.BringToFront();
            }
            else
            {
                MessageBox.Show("Try again, remember your capitals");
            }
        }



        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "e")
            {
                MessageBox.Show("Ses is correct !");
                Form4 f4 = new Form4();
                f4.Show();
                Visible = false;

            }
            else
            {
                MessageBox.Show("Incorrect");
            }
        }

        private void alphabetBackButton_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.MouseClick);
            splayer.Play();
            Form4 a2 = new Form4();
            a2.Show();
            this.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
