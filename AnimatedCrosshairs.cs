using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppXpCrosshairSecondBuild
{
    public partial class AnimatedCrosshairs : UserControl
    {
        Overlay ov = new Overlay();
        WindowedOverlay wol = new WindowedOverlay();

        int addedSize;

        public AnimatedCrosshairs()
        {
            InitializeComponent();
        }

        private void crosshairButton1_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairOne();
        }

        private void crosshairButton2_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairTwo();
        }

        private void crosshairButton3_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairThree();
        }

        private void crosshairButton4_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairFour();
        }

        private void crosshairButton5_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairFive();
        }

        private void crosshairButton6_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairSix();
        }

        private void crosshairButton7_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairSeven();
        }

        private void crosshairButton8_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairEight();
        }

        private void crosshairButton9_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairNine();
        }

        private void crosshairButton10_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairTen();
        }

        private void crosshairButton11_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairEleven();
        }

        private void crosshairButton12_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairTvelwe();
        }

        private void crosshairButton13_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairThirdtheen();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AnimatedCrosshairs_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            wol.Show();
            ov.Show();
            ov.Setup();

            
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            wol.Hide();
            ov.Hide();
        }

        private void crosshairButton14_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairFourteen();
        }

        private void crosshairButton15_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairFiveteen();
        }

        private void crosshairButton16_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairSixteen();
        }

        private void crosshairButton17_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairSeventeen();
        }

        private void crosshairButton18_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairEightteen();
        }

        private void crosshairButton19_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairNineteen();
        }

        private void crosshairButton20_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairTwentie();
        }

        private void crosshairButton21_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairTwentiOne();
        }

        private void crosshairButton22_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairTwentiTwo();
        }

        private void crosshairButton23_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairTwentiThree();
        }

        private void crosshairButton24_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairTwentifour();
        }

        private void crosshairButton25_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairTwentiFive();
        }

        private void crosshairButton26_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairTwentiSix();
        }

        private void crosshairButton27_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairTwentiSeven();
        }

        private void crosshairButton28_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairTwentiEight();
        }

        private void crosshairButton29_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairTwentieNine();
        }

        private void crosshairButton30_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairThirdtee();
        }

        private void crosshairButton31_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairThirdteeOne();
        }

        private void crosshairButton32_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairThirdteeTwo();
        }

        private void crosshairButton33_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairThirdteeThree();
        }

        private void crosshairButton34_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairThirdteeFour();
        }

        private void crosshairButton35_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairThirdteeFive();
        }

        private void crosshairButton36_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairThirdteeSix();
        }

        private void crosshairButton37_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairThirdteeSeven();
        }

        private void crosshairButton38_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairThirdteeEight();
        }

        private void crosshairButton39_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairThirdteeNine();
        }

        private void crosshairButton40_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairFourtie();
        }

        private void crosshairButton41_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairFourtieOne();
        }

        private void crosshairButton42_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairFourtieTwo();
        }

        private void crosshairButton43_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairFourtieThree();
        }

        private void crosshairButton44_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairFourtiefour();
        }

        private void crosshairButton45_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairFourtieFive();
        }

        private void crosshairButton46_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairFourtieSix();
        }

        private void crosshairButton47_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairFourtieSeven();
        }

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            addedSize = Convert.ToInt32(textBox1.Text);

            foreach (Control x in ov.Controls)
            {
                if (x is PictureBox)
                {
                    x.Location = new Point(ov.width - (x.Size.Width / 2), ov.height - (x.Size.Height / 2) - addedSize);
                }
            }
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            addedSize = Convert.ToInt32(textBox1.Text);

            foreach (Control x in ov.Controls)
            {
                if (x is PictureBox)
                {
                    x.Location = new Point(ov.width - (x.Size.Width / 2), ov.height - (x.Size.Height / 2) + addedSize);
                }
            }
        }

        private void crosshairButton48_Click(object sender, EventArgs e)
        {
            ov.EnableAnimatedCrosshairFourtieEight();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            foreach (Control x in ov.Controls)
            {
                if (x is PictureBox)
                {
                    x.Location = new Point(ov.width - (x.Size.Width / 2), ov.height - (x.Size.Height / 2));
                }
            }
        }
    }
}
