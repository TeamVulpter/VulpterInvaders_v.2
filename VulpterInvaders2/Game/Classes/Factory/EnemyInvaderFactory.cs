namespace Game.Classes.Factory
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using Enemies;

    public class EnemyInvaderFactory
    {
        private Random randomY;
        private Random randomX;

        public EnemyInvaderFactory()
        {
            this.randomY = new Random();
            this.randomX = new Random();
        }

        public void CreateEnemies(IList<EnemyShip> enemies)
        {
            foreach (var enemy in enemies)
            {
                enemy.PositionY = this.randomY.Next(10, 100);
                enemy.EnemyInvader.Location = new Point(enemy.PositionX, enemy.PositionY);
            }
        }

        public void CreateSingleEnemy(EnemyShip enemy)
        {
            enemy.PositionY = this.randomY.Next(10, 100);
            enemy.PositionX = this.randomX.Next(10, 500);
            enemy.EnemyInvader.Location = new Point(enemy.PositionX, enemy.PositionY);
        }
    }
}
