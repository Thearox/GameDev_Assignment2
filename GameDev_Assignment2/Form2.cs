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
    public partial class Alphabet : Form
    {
        private bool isClicked = false;
       

        public Alphabet()
        {
            InitializeComponent();
        }

        private void alphabetButton4_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.dfordeur);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton4.Image = Properties.Resources.Deur;
                isClicked = true;
            }
            else
            {
                alphabetButton4.Image = Properties.Resources.D;
                isClicked = false;
            }

        }

        private void alphabetButton24_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.xforxilofoon);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton24.Image = Properties.Resources.Xilofoon;
                isClicked = true;
            }
            else
            {
                alphabetButton24.Image = Properties.Resources.X;
                isClicked = false;
            }
        }

        private void alphabetBackButton_Click_1(object sender, EventArgs e)
        {
            Form1 a2 = new Form1();
            a2.Show();
            this.Hide();
        }

        private void alphabetButton1_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.aforappel);
                splayer.Play();
            }
           if (!isClicked)
            {
                alphabetButton1.Image = Properties.Resources.Appel;
                isClicked = true;
            }
            else
            {
                alphabetButton1.Image = Properties.Resources.A;
                isClicked = false;
            }
           
           

            }

        private void alphabetButton2_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.bforbed);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton2.Image = Properties.Resources.Bed;
                isClicked = true;
            }
            else
            {
                alphabetButton2.Image = Properties.Resources.B;
                isClicked = false;
            }

        }

        private void alphabetButton5_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.eforeend);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton5.Image = Properties.Resources.Eend;
                isClicked = true;
            }
            else
            {
                alphabetButton5.Image = Properties.Resources.E;
                isClicked = false;
            }

        }

        private void alphabetButton6_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.fforflamink);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton6.Image = Properties.Resources.Flamink;
                isClicked = true;
            }
            else
            {
                alphabetButton6.Image = Properties.Resources.F;
                isClicked = false;
            }

        }

        private void alphabetButton7_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.gforgras);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton7.Image = Properties.Resources.Gras;
                isClicked = true;
            }
            else
            {
                alphabetButton7.Image = Properties.Resources.G;
                isClicked = false;
            }

        }

        private void alphabetButton8_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.hforhuis);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton8.Image = Properties.Resources.Huis;
                isClicked = true;
            }
            else
            {
                alphabetButton8.Image = Properties.Resources.H;
                isClicked = false;
            }

        }

        private void alphabetButton9_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.iforigloo);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton9.Image = Properties.Resources.Igloo;
                isClicked = true;
            }
            else
            {
                alphabetButton9.Image = Properties.Resources.I;
                isClicked = false;
            }

        }

        private void alphabetButton10_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.jforjas);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton10.Image = Properties.Resources.Jas;
                isClicked = true;
            }
            else
            {
                alphabetButton10.Image = Properties.Resources.J;
                isClicked = false;
            }

        }

        private void alphabetButton11_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.kforkar);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton11.Image = Properties.Resources.Kar;
                isClicked = true;
            }
            else
            {
                alphabetButton11.Image = Properties.Resources.K;
                isClicked = false;
            }

        }

        private void alphabetButton12_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.lforleer);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton12.Image = Properties.Resources.Leer;
                isClicked = true;
            }
            else
            {
                alphabetButton12.Image = Properties.Resources.L;
                isClicked = false;
            }

        }

        private void alphabetButton13_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.mformuur);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton13.Image = Properties.Resources.Muur;
                isClicked = true;
            }
            else
            {
                alphabetButton13.Image = Properties.Resources.M;
                isClicked = false;
            }

        }

        private void alphabetButton14_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.nforneus);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton14.Image = Properties.Resources.Neus;
                isClicked = true;
            }
            else
            {
                alphabetButton14.Image = Properties.Resources.N;
                isClicked = false;
            }

        }

        private void alphabetButton15_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.oforoor);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton15.Image = Properties.Resources.Oor;
                isClicked = true;
            }
            else
            {
                alphabetButton15.Image = Properties.Resources.O;
                isClicked = false;
            }

        }

        private void alphabetButton16_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.pforpan);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton16.Image = Properties.Resources.Pan;
                isClicked = true;
            }
            else
            {
                alphabetButton16.Image = Properties.Resources.P;
                isClicked = false;
            }

        }

        private void alphabetButton18_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.rforring);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton18.Image = Properties.Resources.Ring;
                isClicked = true;
            }
            else
            {
                alphabetButton18.Image = Properties.Resources.R;
                isClicked = false;
            }

        }

        private void alphabetButton19_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.sforsop);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton19.Image = Properties.Resources.Sop;
                isClicked = true;
            }
            else
            {
                alphabetButton19.Image = Properties.Resources.S;
                isClicked = false;
            }

        }

        private void alphabetButton20_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.tfortier);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton20.Image = Properties.Resources.Tier;
                isClicked = true;
            }
            else
            {
                alphabetButton20.Image = Properties.Resources.T;
                isClicked = false;
            }

        }

        private void alphabetButton22_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.vforvuur);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton22.Image = Properties.Resources.Vuur;
                isClicked = true;
            }
            else
            {
                alphabetButton22.Image = Properties.Resources.V;
                isClicked = false;
            }

        }

        private void alphabetButton23_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.wforwater);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton23.Image = Properties.Resources.Water;
                isClicked = true;
            }
            else
            {
                alphabetButton23.Image = Properties.Resources.W;
                isClicked = false;
            }

        }

        private void alphabetButton25_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.yforys);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton25.Image = Properties.Resources.Ys;
                isClicked = true;
            }
            else
            {
                alphabetButton25.Image = Properties.Resources.Y;
                isClicked = false;
            }

        }

        private void alphabetButton3_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@Properties.Resources.cforchloor);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton3.Image = Properties.Resources.Chloor;
                isClicked = true;
            }
            else
            {
                alphabetButton3.Image = Properties.Resources.C;
                isClicked = false;
            }
        }

        private void alphabetButton21_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.uforuurglas);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton21.Image = Properties.Resources.Uurglas;
                isClicked = true;
            }
            else
            {
                alphabetButton21.Image = Properties.Resources.U;
                isClicked = false;
            }
        }

        private void alphabetButton26_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.zforzero);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton26.Image = Properties.Resources.Zero;
                isClicked = true;
            }
            else
            {
                alphabetButton26.Image = Properties.Resources.Z;
                isClicked = false;
            }
        }

        private void alphabetButton17_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(Properties.Resources.qforquisling);
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton17.Image = Properties.Resources.Quisling;
                isClicked = true;
            }
            else
            {
                alphabetButton17.Image = Properties.Resources.Q;
                isClicked = false;
            }
        }

        private void Alphabet_Load(object sender, EventArgs e)
        {

        }
    }
    }
