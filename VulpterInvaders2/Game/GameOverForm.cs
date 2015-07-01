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

        private void ButtonRestart(object sender, EventArgs e)
        {
           VulpterInvadersGame newGame = new VulpterInvadersGame();
           newGame.Show();
            this.Hide();
        }
    }
}
