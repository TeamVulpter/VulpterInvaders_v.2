using System;

namespace Game
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    using Classes;
    using Classes.Characters;
    using Classes.Enemies;
    using Classes.Factory;

    using Engine;

    public partial class InvadersAttack : Form
    {

        private PlayerShip shipPlayer;
        private Bullet bullet;
        private BulletEnemy enemyShot;
        private bool spaceKeyIsPressed = false;
        private IList<EnemyShip> enemies;
        private Attack attack;
        private EnemyInvaderFactory factoryInvaders;
        private Shooting shooting;
        private Random randomEnemy;
        private Collision collision;

        public InvadersAttack()
        {
            InitializeComponent();
            this.KeyPress += this.InvadersAttack_KeyPress;
            this.KeyDown += this.InvaderAttack_KeyDown;
            this.shipPlayer = new PlayerShip(playerShip);
            this.bullet = new Bullet(bulletPanel);
            this.enemyShot = new BulletEnemy(bulletEnemy);
            this.collision = new Collision();
            randomEnemy = new Random();

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
            attack = new Attack();
            factoryInvaders = new EnemyInvaderFactory();
            shooting = new Shooting();
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
            this.health_value.Text = Health.HelthCount.ToString();
            this.life_value.Text = Life.LifeCount.ToString();

            if (spaceKeyIsPressed)
            {
                this.bullet.PositionX = bullet.PositionX + 10;
                this.bullet = new Bullet(bulletPanel);
                shooting.Shoot(bullet);
                if (bullet.PositionY <= 20)
                {
                    bullet.BulletPanel.Visible = false;
                }

            }

            attack.UpdateAttack(enemies);

            this.enemyShot = new BulletEnemy(bulletEnemy);
            enemyShot.EnemyBullet.Location = new Point(enemyShot.PositionX, enemyShot.PositionY + 10);

            if (enemyShot.PositionY >= 470)
            {
                enemyShot.EnemyBullet.Location = new Point(enemies[randomEnemy.Next(1, 6)].PositionX, enemies[randomEnemy.Next(1, 6)].PositionY + 10);
            }
            enemyShot.Start();
            if (playerShip.Location.X >= enemyShot.EnemyBullet.Location.X && playerShip.Location.X <= (enemyShot.EnemyBullet.Location.X + enemyShot.EnemyBullet.Width) && playerShip.Location.Y >= enemyShot.EnemyBullet.Location.Y &&
                        (playerShip.Location.Y) <= enemyShot.EnemyBullet.Location.Y)
            {
                Life.LifeCount -= 1;
                this.life_value.Text = Life.LifeCount.ToString();

            }
            foreach (var enemy in enemies)
            {
               
                if (collision.EnemyPlayerBullet(bullet, enemy))
                {
                    enemy.EnemyInvader.Visible = false;

                    Score.ScoreCount += 1;
                    this.score_value.Text = Score.ScoreCount.ToString();
                    break;

                }
            }


        }
    }
}
