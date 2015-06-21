using System;
using System.Windows.Forms;
using Game.Classes;
using Game.Classes.Characters;

namespace Game
{
    public partial class FormMenuUI : Form
    {
        //private Player player;

        public FormMenuUI()
        {
            InitializeComponent();
        }

        private void Btn_StartNewGame_Click(object sender, EventArgs e)
        {
            //if (this.player != null)
            //{
                
                VulpterInvadersGame newGame = new VulpterInvadersGame();
                this.Hide();
                newGame.Show();
                
            //}
            //else
            //{
            //    MessageBox.Show("Not created hero. First create hero and then try again!");
            //}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormMenuUI_Load(object sender, EventArgs e)
        {

        }

        //private void Btn_NewPlayer_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //create hero
        //        this.player = new Player(350, 560, hero);
        //        //add default values
        //        this.player.AddHealth(Health.HelthCount);
        //        this.player.AddLives(Life.LifeCount);
        //        this.player.AddScores(Score.ScoreCount);
        //        MessageBox.Show("Hero is created!");
        //    }
        //    catch (NotImplementedException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
            
        //}
    }
}
