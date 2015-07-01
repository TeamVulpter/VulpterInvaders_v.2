namespace Game.Classes.Factory
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using Enemies;

    public class EnemyInvaderFactory
    {
        private Random randomX = new Random();
        private Random randomY = new Random();

        public void CreateEnemy(IList<EnemyShip> enemies)
        {
            foreach (var enemy in enemies)
            {

                enemy.PositionY = randomY.Next(10, 100);

                enemy.EnemyInvader.Location = new Point(enemy.PositionX, enemy.PositionY);

            }
        }
    }
}
