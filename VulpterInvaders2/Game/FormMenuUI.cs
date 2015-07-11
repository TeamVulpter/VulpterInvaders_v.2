namespace Game
{
    using System;
    using System.Media;
    using System.Windows.Forms;

    using Game.Loader;

    public partial class FormMenuUI : Form
    {
        private readonly SoundPlayer musicPlayer;

        private GameLoader engineGameLoader;

        public FormMenuUI(GameLoader engineGameLoader)
        {
            this.engineGameLoader = engineGameLoader;
            this.InitializeComponent();
            this.musicPlayer = new System.Media.SoundPlayer("../../Resources/Song/GameMusic.wav");
            this.musicPlayer.PlayLooping();
        }

        private void Btn_StartNewGame_Click(object sender, EventArgs e)
        {
                VulpterInvadersGame newGame = new VulpterInvadersGame(this.engineGameLoader);
                newGame.Show();
                this.Hide();
        }

        private void PlayMusic_Click(object sender, System.EventArgs e)
        {
            musicPlayer.PlayLooping();
        }

        private void StopMusic_Click(object sender, System.EventArgs e)
        {
            musicPlayer.Stop();
        }
    }
}
