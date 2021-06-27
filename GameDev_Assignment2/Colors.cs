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
    public partial class Colors : Form
    {
        public Colors()
        {
            InitializeComponent();
        }

        private void objectbackButton_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.MouseClick);
            splayer.Play();
            Words w8 = new Words();
            w8.Show();
            Visible = false;
        }

        private void swartt_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.swart3);
            splayer.Play();
        }

        private void bruinn_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.bruin3);
            splayer.Play();
        }

        private void blouu_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.blou3);
            splayer.Play();
        }

        private void perss_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.pers3);
            splayer.Play();
        }

        private void groenn_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.groen3);
            splayer.Play();
        }

        private void rooii_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.rooi3);
            splayer.Play();
        }

        private void oranjee_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.oranje3);
            splayer.Play();
        }

        private void pinkk_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.pink3);
            splayer.Play();
        }

        private void geell_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.geel3);
            splayer.Play();
        }

        private void witt_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.wit3);
            splayer.Play();
        }
    }
}
