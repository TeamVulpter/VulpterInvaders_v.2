using System.Media;

namespace Game
{
    using System;
    using System.Net.Mime;
    using System.Windows.Forms;

    public partial class FormMenuUI : Form
    {
        private SoundPlayer musicPlayer;
        public FormMenuUI()
        {
            InitializeComponent();
            musicPlayer=new System.Media.SoundPlayer("../../Resources/Song/GameMusic.wav");
            musicPlayer.PlayLooping();
        }

        private void Btn_StartNewGame_Click(object sender, EventArgs e)
        {
            
                VulpterInvadersGame newGame = new VulpterInvadersGame();
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
