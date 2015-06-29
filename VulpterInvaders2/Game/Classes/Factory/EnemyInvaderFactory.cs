﻿namespace Game.Classes.Factory
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using Enemies;

    public class EnemyInvaderFactory
    {
        private Random randomX = new Random();
       
        public void CreateEnemy(IList<EnemyShip>enemies)
        {
            foreach (var enemy in enemies)
            {
                
                enemy.PositionX = randomX.Next(10, 500);
                enemy.PositionY = 20;
                enemy.EnemyInvader.Location = new Point(enemy.PositionX, enemy.PositionY);
            }
        }
    }
}
