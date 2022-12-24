using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppXpCrosshairSecondBuild
{
    public partial class Overlay : Form
    {
        public int height, width;

        public static string WINDOW_NAME = "WindowedOverlay";

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        public static IntPtr handle = FindWindow(null, WINDOW_NAME);


        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]

        public static extern bool GetWindowRect(IntPtr hwnd, out RECT IpRect);

        public static RECT rect;


        public struct RECT
        {
            public int left, top, right, bottom;
        }

        public Overlay()
        {
            InitializeComponent();
        }

        private void Overlay_Load(object sender, EventArgs e)
        {

            CheckForIllegalCrossThreadCalls = false;

            this.BackColor = Color.Wheat;
            this.TransparencyKey = Color.Wheat;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            GetWindowRect(handle, out rect);
            this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);

            this.Left = rect.left;
            this.Top = rect.top;

            int initialstyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialstyle | 0x8000 | 0x20);

            height = this.Height;
            width = this.Width;


            height = height / 2;
            width = width / 2;

            

        }

        public void Setup()
        {
            
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    x.Location = new Point(width - (x.Size.Width / 2), height - (x.Size.Height / 2));
                }
            }

            HideAll();
        }

        public void HideAll()
        {
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox) 
                {
                    x.Hide();
                }
            }
        }

        public void EnableAnimatedCrosshairOne()
        {
            HideAll();
            crosshairPicture1.Show();
        }

        public void EnableAnimatedCrosshairTwo()
        {
            HideAll();
            crosshairPicture2.Show();
        }

        public void EnableAnimatedCrosshairThree()
        {
            HideAll();
            crosshairPicture3.Show();
        }

        public void EnableAnimatedCrosshairFour()
        {
            HideAll();
            crosshairPicture4.Show();
        }

        public void EnableAnimatedCrosshairFive()
        {
            HideAll();
            crosshairPicture5.Show();
        }

        public void EnableAnimatedCrosshairSix()
        {
            HideAll();
            crosshairPicture6.Show();
        }

        public void EnableAnimatedCrosshairSeven()
        {
            HideAll();
            crosshairPicture7.Show();
        }

        public void EnableAnimatedCrosshairEight()
        {
            HideAll();
            crosshairPicture8.Show();
        }

        public void EnableAnimatedCrosshairNine()
        {
            HideAll();
            crosshairPicture9.Show();
        }

        public void EnableAnimatedCrosshairTen()
        {
            HideAll();  
            crosshairPicture10.Show();
        }

        public void EnableAnimatedCrosshairEleven()
        {
            HideAll();
            crosshairPicture11.Show();
        }

        private void crosshairPicture2_Click(object sender, EventArgs e)
        {

        }

        public void EnableAnimatedCrosshairTvelwe()
        {
            HideAll();
            crosshairPicture12.Show();
        }

        public void EnableAnimatedCrosshairThirdtheen()
        {
            HideAll();
            crosshairPicture13.Show();

            
        }

        public void EnableAnimatedCrosshairFourteen()
        {
            HideAll();
            crosshairPicture14.Show();
        }

        public void EnableAnimatedCrosshairFiveteen() 
        {
            HideAll();
            crosshairPicture15.Show();
        }

        public void EnableAnimatedCrosshairSixteen()
        {
            HideAll();
            crosshairPicture16.Show();
        }

        public void EnableAnimatedCrosshairSeventeen()
        {
            HideAll();
            crosshairPicture17.Show();
        }

        public void EnableAnimatedCrosshairEightteen()
        {
            HideAll();
            crosshairPicture18.Show();
        }

        public void EnableAnimatedCrosshairNineteen()
        {
            HideAll();
            crosshairPicture19.Show();
        }

        public void EnableAnimatedCrosshairTwentie()
        {
            HideAll();
            crosshairPicture20.Show();
        }

        public void EnableAnimatedCrosshairTwentiOne()
        {
            HideAll();
            crosshairPicture21.Show();
        }

        public void EnableAnimatedCrosshairTwentiTwo()
        {
            HideAll();
            crosshairPicture22.Show();
        }

        public void EnableAnimatedCrosshairTwentiThree()
        {
            HideAll();
            crosshairPicture23.Show();
        }

        public void EnableAnimatedCrosshairTwentifour()
        {
            HideAll();
            crosshairPicture24.Show();
        }

        public void EnableAnimatedCrosshairTwentiFive()
        {
            HideAll();
            crosshairPicture25.Show();
        }
        public void EnableAnimatedCrosshairTwentiSix()
        {
            HideAll();
            crosshairPicture26.Show();
        }

        public void EnableAnimatedCrosshairTwentiSeven()
        {
            HideAll();
            crosshairPicture27.Show();
        }

        public void EnableAnimatedCrosshairTwentiEight()
        {
            HideAll();
            crosshairPicture28.Show();
        }

        public void EnableAnimatedCrosshairTwentieNine()
        {
            HideAll();
            crosshairPicture29.Show();
        }

        public void EnableAnimatedCrosshairThirdtee()
        {
            HideAll();
            crosshairPicture30.Show();
        }

        public void EnableAnimatedCrosshairThirdteeOne()
        {
            HideAll();
            crosshairPicture31.Show();
        }

        public void EnableAnimatedCrosshairThirdteeTwo()
        {
            HideAll();
            crosshairPicture32.Show();
        }

        public void EnableAnimatedCrosshairThirdteeThree()
        {
            HideAll();
            crosshairPicture33.Show();
        }

        public void EnableAnimatedCrosshairThirdteeFour()
        {
            HideAll();
            crosshairPicture34.Show();
        }
        public void EnableAnimatedCrosshairThirdteeFive()
        {
            HideAll();
            crosshairPicture35.Show();
        }
        public void EnableAnimatedCrosshairThirdteeSix()
        {
            HideAll();
            crosshairPicture36.Show();
        }
        public void EnableAnimatedCrosshairThirdteeSeven()
        {
            HideAll();
            crosshairPicture37.Show();
        }
        public void EnableAnimatedCrosshairThirdteeEight()
        {
            HideAll();
            crosshairPicture38.Show();
        }
        public void EnableAnimatedCrosshairThirdteeNine()
        {
            HideAll();
            crosshairPicture39.Show();
        }
        public void EnableAnimatedCrosshairFourtie()
        {
            HideAll();
            crosshairPicture40.Show();
        }
        public void EnableAnimatedCrosshairFourtieOne()
        {
            HideAll();
            crosshairPicture41.Show();
        }
        public void EnableAnimatedCrosshairFourtieTwo()
        {
            HideAll();
            crosshairPicture42.Show();
        }
        public void EnableAnimatedCrosshairFourtieThree()
        {
            HideAll();
            crosshairPicture43.Show();
        }

        public void EnableAnimatedCrosshairFourtiefour()
        {
            HideAll();
            crosshairPicture44.Show();
        }

        public void EnableAnimatedCrosshairFourtieFive()
        {
            HideAll();
            crosshairPicture45.Show();
        }

        public void EnableAnimatedCrosshairFourtieSix()
        {
            HideAll();
            crosshairPicture46.Show();
        }

        public void EnableAnimatedCrosshairFourtieSeven()
        {
            HideAll();
            crosshairPicture47.Show();
        }

        private void crosshairPicture31_Click(object sender, EventArgs e)
        {

        }

        public void EnableAnimatedCrosshairFourtieEight()
        {
            HideAll();
            crosshairPicture48.Show();
        }



    }
}
