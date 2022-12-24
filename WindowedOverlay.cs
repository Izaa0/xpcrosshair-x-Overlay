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
    public partial class WindowedOverlay : Form
    {
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


        
        public WindowedOverlay()
        {
            InitializeComponent();
        }

        private void WindowedOverlay_Load(object sender, EventArgs e)
        {

            CheckForIllegalCrossThreadCalls = false;

            this.BackColor = Color.Wheat;
            this.TransparencyKey = Color.Wheat;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            WindowState = FormWindowState.Maximized;

            int initialstyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialstyle | 0x8000 | 0x20);

            
        }


    }
}
