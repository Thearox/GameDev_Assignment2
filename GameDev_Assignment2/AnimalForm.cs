using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GameDev_Assignment2
{
    public partial class AnimalForm : Form
    {
        public AnimalForm()
        {
            InitializeComponent();
        }

        private void animalBackButton_Click(object sender, EventArgs e)
        {
            Words a2 = new Words();
            a2.Show();
            this.Hide();
        }

        private void aHond_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.aHond1);
                splayer.Play();
            }
        }

        private void aKat_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.aKat1);
                splayer.Play();
            }
        }

        private void aKoei_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.aKoei1);
                splayer.Play();
            }
        }

        private void aLeeu_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.aLeeu1);
                splayer.Play();
            }
        }

        private void aOlifant_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.aOlifant1);
                splayer.Play();
            }
        }

        private void aPerd_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.aPerd1);
                splayer.Play();
            }
        }

        private void aSkaap_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.aSkaap1);
                splayer.Play();
            }
        }

        private void aSlang_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.aSlang1);
                splayer.Play();
            }
        }

        private void aVark_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.aVark1);
                splayer.Play();
            }
        }

        private void aVoel_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.aVoel1);
                splayer.Play();
            }
        }

        private void AnimalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
