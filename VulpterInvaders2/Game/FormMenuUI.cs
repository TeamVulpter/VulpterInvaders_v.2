namespace Game
{
    using System;
    using System.Net.Mime;
    using System.Windows.Forms;

    public partial class FormMenuUI : Form
    {
        bool isFormOpen = false;
        public FormMenuUI()
        {
            InitializeComponent();
        }

        private void Btn_StartNewGame_Click(object sender, EventArgs e)
        {
            
                VulpterInvadersGame newGame = new VulpterInvadersGame();
                newGame.Show();
                this.Hide();
        }
    }
}
