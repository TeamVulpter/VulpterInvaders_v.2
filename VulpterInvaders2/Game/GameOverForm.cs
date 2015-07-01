using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
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
