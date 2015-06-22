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
using Game.Classes.Enemies;

namespace Game
{
    public partial class InvadersAttack : Form
    {
        private PlayerShip shipPlayer;
        private Bullet bullet;
        private EnemyShip enemy;
        
        
        public InvadersAttack()
        {
            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InvaderAttack_KeyDown);
            this.shipPlayer = new PlayerShip(500, 0, playerShip);
            this.bullet = new Bullet(shipPlayer.PositionX, 40, bulletPanel);
            this.enemy = new EnemyShip(shipEnemy.Location.X, shipEnemy.Location.Y, shipEnemy);
        }


        private void InvaderAttack_KeyDown(object sender, KeyEventArgs e)
        {
            this.shipPlayer.PositionX = playerShip.Location.X;
            this.shipPlayer.PositionY = playerShip.Location.Y;
            this.bullet.PositionX = bulletPanel.Location.X;
            this.bullet.PositionY = bulletPanel.Location.Y;

            if (e.KeyCode == Keys.A)
            {
                playerShip.Location = new Point(shipPlayer.PositionX - 10, shipPlayer.PositionY);
                if (playerShip.Location.X < 20)
                {
                    playerShip.Location = new Point(shipPlayer.PositionX, shipPlayer.PositionY);
                }
            }
            if (e.KeyCode == Keys.D)
            {
                playerShip.Location = new Point(shipPlayer.PositionX + 10, shipPlayer.PositionY);
                if (playerShip.Location.X > this.Width - 30)
                {
                    playerShip.Location = new Point(shipPlayer.PositionX, shipPlayer.PositionY);
                }
            }
            if (e.KeyCode == Keys.Space)
            {
                bulletPanel.Location = new Point(shipPlayer.PositionX, bullet.PositionY - 10);
                bullet.Start();
                bullet.IsActive = true;
            }
        }

        private void TimerMovementsTick(object sender, System.EventArgs e)
        {
            this.enemy.PositionX = shipEnemy.Location.X;
            this.enemy.PositionY = shipEnemy.Location.Y;

            shipEnemy.Location = new Point(enemy.PositionX, enemy.PositionY + 1);
            if (enemy.PositionY>=this.Height-30)
            {
                shipEnemy.Location = new Point(enemy.PositionX, 10);
            }

            //bulletPanel.Location = new Point(shipPlayer.PositionX, bullet.PositionY-1);
        }
    }
}
