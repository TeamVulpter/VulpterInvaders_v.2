using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game.Classes.Characters;

namespace Game
{
    public partial class InvadersAttack : Form
    {
        private Player player;
        public InvadersAttack()
        {
            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InvaderAttack_KeyDown);
            this.player = new Player(500, 0, playerShip);
        }


        private void InvaderAttack_KeyDown(object sender, KeyEventArgs e)
        {
            this.player.PositionX = playerShip.Location.X;
            this.player.PositionY = playerShip.Location.Y;
            if (e.KeyCode == Keys.A)
            {
                playerShip.Location = new Point(player.PositionX-10, player.PositionY);
            }
             if (e.KeyCode == Keys.D)
             {
                 playerShip.Location = new Point(player.PositionX+10, player.PositionY);
             }
        }
    }
}
