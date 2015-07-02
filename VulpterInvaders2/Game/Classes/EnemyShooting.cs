namespace Game.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    using Enemies;
    using Interfaces;

    public class EnemyShooting:IShootEnemy
    {
        private Random randomEnemy;

        public EnemyShooting()
        {
            this.randomEnemy = new Random();
        }

        public void EnemyShoot(BulletEnemy enemyShot, IList<EnemyShip> enemies)
        {
            enemyShot.EnemyBullet.Location = new Point(enemyShot.PositionX, enemyShot.PositionY + 10);

            if (enemyShot.PositionY >= 500)
            {
                enemyShot.EnemyBullet.Location = new Point(enemies[this.randomEnemy.Next(1, 6)].PositionX, enemies[this.randomEnemy.Next(1, 6)].PositionY + 10);
            }
            enemyShot.Start();
        }
    }
}
