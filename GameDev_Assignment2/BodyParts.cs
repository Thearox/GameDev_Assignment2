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
    public partial class BodyParts : Form
    {
        public BodyParts()
        {
            InitializeComponent();
        }

        private void objectbackButtonbp_Click(object sender, EventArgs e)
        {
            Words w3 = new Words();
            w3.Show();
            Visible = false;
        }

        private void armm_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.arm3);
            splayer.Play();
        }

        private void beenn_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.been3);
            splayer.Play();
        }

        private void handd_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.hand3);
            splayer.Play();
        }

        private void voett_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.voet3);
            splayer.Play();
        }

        private void neuss_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.neus3);
            splayer.Play();
        }

        private void oorr_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.oor3);
            splayer.Play();
        }

        private void mondd_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.mond3);
            splayer.Play();
        }

        private void nekk_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.nek3);
            splayer.Play();
        }

        private void vingerr_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.vinger3);
            splayer.Play();
        }

        private void oogg_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.oog3);
            splayer.Play();
        }
    }
}
