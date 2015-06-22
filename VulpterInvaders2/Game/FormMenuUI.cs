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
            VulpterInvadersGame newGame = new VulpterInvadersGame();
            this.Hide();
            newGame.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormMenuUI_Load(object sender, EventArgs e)
        {

        }

        //private void Btn_NewPlayer_Click(object sender, EventArgs e)
        //{
        //}
    }
}
