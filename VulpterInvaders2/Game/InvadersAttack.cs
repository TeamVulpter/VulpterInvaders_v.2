using System.Collections.Generic;
using Game.Classes.Factory;

namespace Game
{
    using System.Drawing;
    using System.Windows.Forms;

    using Classes;
    using Classes.Characters;
    using Classes.Enemies;
    using System.Collections;

    public partial class InvadersAttack : Form
    {

        private PlayerShip shipPlayer;
        private Bullet bullet;
        private EnemyShip enemy;
        private bool spaceKeyIsPressed = false;
        private IList<EnemyShip> enemies;
        private EnemyInvaderFactory factoryInvaders;

        public InvadersAttack()
        {
            InitializeComponent();
            this.KeyPress += this.InvadersAttack_KeyPress;
            this.KeyDown += this.InvaderAttack_KeyDown;
            this.shipPlayer = new PlayerShip(playerShip);
            this.bullet = new Bullet(shipPlayer.PositionX, shipPlayer.PositionY, bulletPanel);
            //this.enemy = new EnemyShip(shipEnemy);

            enemies = new List<EnemyShip>()
            {
                new EnemyShip(shipEnemy),
                new EnemyShip(invaderTwo),
                new EnemyShip(invaderThree),
                new EnemyShip(invaderFour),
                new EnemyShip(invaderFive),
                new EnemyShip(invaderSix),
                new EnemyShip(invaderSeven),
                new EnemyShip(invaderEight)
            };
            factoryInvaders = new EnemyInvaderFactory();
            factoryInvaders.CreateEnemy(enemies);


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

            //shipEnemy.Location = new Point(enemy.PositionX, enemy.PositionY + 1);
            //if (enemy.PositionY >= this.Height - 30)
            //{
            //    shipEnemy.Location = new Point(enemy.PositionX, 10);
            //}
        }
    }
}
