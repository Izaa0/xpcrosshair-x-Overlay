namespace WinFormsAppXpCrosshairSecondBuild
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Minimized; 
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Maximized;
        }

        void HideAllPanels()
        {
            
            animatedCrosshairsPanel.Hide();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HideAllPanels();
        }

        private void StaticCrosshairsButton_Click(object sender, EventArgs e)
        {
            HideAllPanels();
        }

        private void AnimatedCrosshairsButton_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            animatedCrosshairsPanel.Show();
        }

        private void CrosshairSettings_Click(object sender, EventArgs e)
        {

        }

        private void animatedCrosshairsPanel_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {

        }
    }
}