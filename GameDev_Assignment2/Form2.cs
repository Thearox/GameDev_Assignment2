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
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\dfordeur.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton4.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Deur.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton4.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\D.jpg");
                isClicked = false;
            }

        }

        private void alphabetButton24_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\xforxilofoon.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton24.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Xilofoon.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton24.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\X.jpg");
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
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\aforappel.wav");
                splayer.Play();
            }
           if (!isClicked)
            {
                alphabetButton1.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Appel.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton1.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\A.jpg");
                isClicked = false;
            }
           
           

            }

        private void alphabetButton2_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\bforbed.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton2.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Bed.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton2.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\B.jpg");
                isClicked = false;
            }

        }

        private void alphabetButton5_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\eforeend.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton5.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Eend.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton5.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\E.jpg");
                isClicked = false;
            }

        }

        private void alphabetButton6_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\fforflamink.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton6.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Flamink.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton6.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\F.jpg");
                isClicked = false;
            }

        }

        private void alphabetButton7_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\gforgras.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton7.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Gras.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton7.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\G.jpg");
                isClicked = false;
            }

        }

        private void alphabetButton8_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\hforhuis.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton8.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Huis.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton8.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\H.jpg");
                isClicked = false;
            }

        }

        private void alphabetButton9_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\iforigloo.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton9.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Igloo.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton9.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\I.jpg");
                isClicked = false;
            }

        }

        private void alphabetButton10_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\jforjas.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton10.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Jas.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton10.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\J.jpg");
                isClicked = false;
            }

        }

        private void alphabetButton11_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\kforkar.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton11.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Kar.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton11.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\K.jpg");
                isClicked = false;
            }

        }

        private void alphabetButton12_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\lforleer.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton12.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Leer.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton12.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\L.jpg");
                isClicked = false;
            }

        }

        private void alphabetButton13_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\mformuur.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton13.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Muur.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton13.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\M.jpg");
                isClicked = false;
            }

        }

        private void alphabetButton14_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\nforneus.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton14.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Neus.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton14.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\N.jpg");
                isClicked = false;
            }

        }

        private void alphabetButton15_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\oforoor.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton15.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Oor.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton15.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\O.jpg");
                isClicked = false;
            }

        }

        private void alphabetButton16_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\pforpan.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton16.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Pan.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton16.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\P.jpg");
                isClicked = false;
            }

        }

        private void alphabetButton18_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\rforring.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton18.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Ring.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton18.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\R.jpg");
                isClicked = false;
            }

        }

        private void alphabetButton19_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\sforsop.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton19.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Sop.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton19.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\S.jpg");
                isClicked = false;
            }

        }

        private void alphabetButton20_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\tfortier.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton20.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Tier.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton20.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\T.jpg");
                isClicked = false;
            }

        }

        private void alphabetButton22_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\vforvuur.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton22.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Vuur.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton22.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\V.jpg");
                isClicked = false;
            }

        }

        private void alphabetButton23_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\wforwater.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton23.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Water.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton23.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\W.jpg");
                isClicked = false;
            }

        }

        private void alphabetButton25_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\yforys.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton25.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Ys.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton25.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\Y.jpg");
                isClicked = false;
            }

        }

        private void alphabetButton3_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\cforchloor.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton3.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Chloor.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton3.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\C.jpg");
                isClicked = false;
            }
        }

        private void alphabetButton21_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\uforuurglas.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton21.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Uurglas.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton21.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\U.jpg");
                isClicked = false;
            }
        }

        private void alphabetButton26_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\zforzero.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton26.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Zero.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton26.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\Z.jpg");
                isClicked = false;
            }
        }

        private void alphabetButton17_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\audio\qforquisling.wav");
                splayer.Play();
            }
            if (!isClicked)
            {
                alphabetButton17.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\photos\Quisling.jpg");
                isClicked = true;
            }
            else
            {
                alphabetButton17.Image = Image.FromFile(@"C:\Users\Lenovo\source\repos\GameDev_Assignment2\GameDev_Assignment2\Resources\Q.jpg");
                isClicked = false;
            }
        }
    }
    }
