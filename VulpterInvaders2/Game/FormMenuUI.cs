namespace Game
{
    using System;
    using System.Windows.Forms;

    public partial class FormMenuUI : Form
    {
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
        
        private void FormMenuUI_Load(object sender, EventArgs e)
        {
        }
    }
}
