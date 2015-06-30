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
       
        public void CreateEnemy(IList<EnemyShip>enemies)
        {
            foreach (var enemy in enemies)
            {
                
                enemy.PositionX = randomX.Next(10, 500);
                enemy.PositionY = randomY.Next(10,300);
                for (int i = 0; i < enemies.Count - 1; i++)
                {
                    if (enemies[i].PositionX + enemies[i].EnemyInvader.Width < enemies[i + 1].PositionX)
                    {
                        enemy.EnemyInvader.Location = new Point(enemy.PositionX, enemy.PositionY);
                    }
                }
            }
        }
    }
}
