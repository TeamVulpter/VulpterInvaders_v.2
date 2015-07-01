using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Classes.Enemies;
using Game.Interfaces;

namespace Game.Classes
{
    public class EnemyShooting:IShootableEnemyBullet
    {
        private Random randomEnemy;

        public EnemyShooting()
        {
            randomEnemy = new Random();
        }
        public void EnemyShoot(BulletEnemy enemyShot, IList<EnemyShip> enemies)
        {
            enemyShot.EnemyBullet.Location = new Point(enemyShot.PositionX, enemyShot.PositionY + 10);

            if (enemyShot.PositionY >= 500)
            {
                enemyShot.EnemyBullet.Location = new Point(enemies[randomEnemy.Next(1, 6)].PositionX, enemies[randomEnemy.Next(1, 6)].PositionY + 10);
            }
            enemyShot.Start();
        }

       
    }
}
