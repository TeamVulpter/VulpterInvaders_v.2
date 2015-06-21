using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game.Classes;
using Game.Classes.Characters;

namespace Game
{
    public partial class InvadersAttack : Form
    {
        private PlayerShip shipPlayer;
        private Bullet bullet;
        public InvadersAttack()
        {
            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InvaderAttack_KeyDown);
            this.shipPlayer = new PlayerShip(500, 0, playerShip);
            this.bullet = new Bullet(shipPlayer.PositionX, 40, bulletPanel);
        }


        private void InvaderAttack_KeyDown(object sender, KeyEventArgs e)
        {
            this.shipPlayer.PositionX = playerShip.Location.X;
            this.shipPlayer.PositionY = playerShip.Location.Y;
            this.bullet.PositionX = bulletPanel.Location.X;
            this.bullet.PositionY = bulletPanel.Location.Y;
            if (e.KeyCode == Keys.A)
            {
                playerShip.Location = new Point(shipPlayer.PositionX-10, shipPlayer.PositionY);
            }
             if (e.KeyCode == Keys.D)
             {
                 playerShip.Location = new Point(shipPlayer.PositionX+10, shipPlayer.PositionY);
             }
            if (e.KeyCode==Keys.Space)
            {
                bulletPanel.Location = new Point(bullet.PositionX, bullet.PositionY-10);
                bullet.Start();
            }
        }
    }
}
