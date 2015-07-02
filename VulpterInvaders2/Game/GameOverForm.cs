namespace Game
{
    using System;
    using System.Windows.Forms;

    public partial class GameOverForm : Form
    {
        public GameOverForm()
        {
            InitializeComponent();
        }

        private void ButtonExitClick(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void RestartGame_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
            this.Close();
        }
    }
}