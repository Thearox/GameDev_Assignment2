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
    public partial class FruitForm : Form
    {
        public FruitForm()
        {
            InitializeComponent();
        }

        private void fruitBackButton_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.MouseClick);
            splayer.Play();
            Words a2 = new Words();
            a2.Show();
            this.Hide();
        }

        private void fAppel_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.fAppel1);
                splayer.Play();
            }
        }

        private void fDruif_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.fDruif1);
                splayer.Play();
            }
        }

        private void fLemoen_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.fLemoen1);
                splayer.Play();
            }
        }

        private void fPeer_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.fPeer1);
                splayer.Play();
            }
        }

        private void fPerske_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.fPerske1);
                splayer.Play();
            }
        }

        private void fPiesang_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.fPiesang1);
                splayer.Play();
            }
        }

        private void fPruim_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.fPruim1);
                splayer.Play();
            }
        }

        private void fPynappel_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.fPynappel1);
                splayer.Play();
            }
        }

        private void fTamatie_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.fTamatie1);
                splayer.Play();
            }
        }

        private void fVy_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.fVy1);
                splayer.Play();
            }
        }

        private void FruitForm_Load(object sender, EventArgs e)
        {

        }
    }
}
