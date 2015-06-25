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
        private bool spaceKeyIsPressed = false;


        public InvadersAttack()
        {
            InitializeComponent();
            this.KeyPress += this.InvadersAttack_KeyPress;
            this.KeyDown += this.InvaderAttack_KeyDown;
            this.shipPlayer = new PlayerShip(playerShip.Location.X, playerShip.Location.Y, playerShip);
            this.bullet = new Bullet(shipPlayer.PositionX, shipPlayer.PositionY, bulletPanel);
            this.enemy = new EnemyShip(shipEnemy.Location.X, shipEnemy.Location.Y, shipEnemy);
        }

        private void InvadersAttack_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Space)
            {
                spaceKeyIsPressed = true;
                bulletPanel.Location = new Point(playerShip.Location.X, 450);
            }
        }


        private void InvaderAttack_KeyDown(object sender, KeyEventArgs e)
        {
            if (!shipPlayer.StopAtMin(playerShip.Location.X, 20))
            {

                if (e.KeyCode == Keys.A)
                {

                    shipPlayer.MoveLeft();
                }

            }
            if (!shipPlayer.StopAtMax(playerShip.Location.X, this.Width - 70))
            {
                if (e.KeyCode == Keys.D)
                {

                    shipPlayer.MoveRight();
                }
            }
        }

        private void TimerMovementsTick(object sender, System.EventArgs e)
        {
            if (spaceKeyIsPressed)
            {
                this.bullet.PositionX = bulletPanel.Location.X;
                this.bullet.PositionY = bulletPanel.Location.Y;
                this.bullet = new Bullet(playerShip.Location.X, bullet.PositionY, bulletPanel);
                bulletPanel.Location = new Point(playerShip.Location.X, bullet.PositionY - 10);
                bullet.Start();


            }

            this.enemy.PositionX = shipEnemy.Location.X;
            this.enemy.PositionY = shipEnemy.Location.Y;

            shipEnemy.Location = new Point(enemy.PositionX, enemy.PositionY + 1);
            if (enemy.PositionY >= this.Height - 30)
            {
                shipEnemy.Location = new Point(enemy.PositionX, 10);
            }
        }
    }
}
