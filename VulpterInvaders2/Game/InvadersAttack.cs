namespace Game
{
    using System.Linq;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    using Classes;
    using Classes.Characters;
    using Classes.Enemies;
    using Classes.Factory;

    public partial class InvadersAttack : Form
    {

        private PlayerShip shipPlayer;
        private BulletPlayer bullet;
        private BulletEnemy enemyShot;
        private bool spaceKeyIsPressed = false;
        private IList<EnemyShip> enemies;
        private Attack attack;
        private EnemyInvaderFactory factoryInvaders;
        private Shooting shooting;
        private EnemyShooting enemyShooting;
   
        private InvadersAttackCollision collision;

        public InvadersAttack()
        {
            InitializeComponent();
            this.KeyPress += this.InvadersAttack_KeyPress;
            this.KeyDown += this.InvaderAttack_KeyDown;
            this.shipPlayer = new PlayerShip(playerShip);
            this.bullet = new BulletPlayer(bulletPanel);
            this.enemyShot = new BulletEnemy(bulletEnemy);
            this.collision = new InvadersAttackCollision();
            this.enemyShooting = new EnemyShooting();
         

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
            factoryInvaders.CreateEnemies(enemies);

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
            this.life_value.Text = Life.LifeCount.ToString();

            if (Life.LifeCount <= 0 || Score.ScoreCount>=100)
            {
                GameOverForm gameOver = new GameOverForm();
                gameOver.Show();
                this.Close();
            }

            if (spaceKeyIsPressed)
            {
                this.bullet.PositionX = bullet.PositionX + 10;
                this.bullet = new BulletPlayer(bulletPanel);
                this.shooting.Shoot(bullet);
            }

            attack.UpdateAttack(enemies);

            this.enemyShot = new BulletEnemy(bulletEnemy);
            this.enemyShooting.EnemyShoot(enemyShot, enemies);

            if (collision.EnemyShotPlayerShipCollision(shipPlayer, enemyShot) && enemyShot.EnemyBullet.Visible)
            {
                Life.LifeCount -= 1;
                this.life_value.Text = Life.LifeCount.ToString();
            }
            foreach (var enemy in enemies)
            {
                if (collision.EnemyPlayerBullet(bullet, enemy))
                {
                    factoryInvaders.CreateSingleEnemy(enemy);

                    Score.ScoreCount += 1;
                    this.score_value.Text = Score.ScoreCount.ToString();
                    break;
                }
               
                if (enemy.PositionY >= 450)
                {
                    Life.LifeCount -= 1;
                    if (Life.LifeCount < 1)
                    {
                        Life.LifeCount = 0;
                    }
                    factoryInvaders.CreateSingleEnemy(enemy);
                }
            }
        }
    }
}
