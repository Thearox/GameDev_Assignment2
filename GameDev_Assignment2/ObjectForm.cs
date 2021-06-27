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
    public partial class ObjectForm : Form
    {
        public ObjectForm()
        {
            InitializeComponent();
        }

        private void objectBackButton_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.MouseClick);
            splayer.Play();
            Words a2 = new Words();
            a2.Show();
            this.Hide();
        }

        private void oBril_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.oBril1);
                splayer.Play();
            }
        }

        private void oDeur_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.oDeur1);
                splayer.Play();
            }
        }

        private void oFoon_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.oFoon1);
                splayer.Play();
            }
        }

        private void oHuis_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.oHuis1);
                splayer.Play();
            }
        }

        private void oKar_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.oKar1);
                splayer.Play();
            }
        }

        private void oMotorfiets_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.oMotorfiets1);
                splayer.Play();
            }
        }

        private void oRekenaar_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.oRekenaar1);
                splayer.Play();
            }
        }

        private void oSleutel_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.oSleutel1);
                splayer.Play();
            }
        }

        private void oStoel_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.oStoel1);
                splayer.Play();
            }
        }

        private void oTafel_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.oTafel1);
                splayer.Play();
            }
        }
    }
}
