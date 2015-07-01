namespace Game.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    using Enemies;
    using Interfaces;

    public class Attack : IAttack
    {
        private Random randomY = new Random();
        public void UpdateAttack(IList<EnemyShip> enemies)
        {
            foreach (var en in enemies)
            {
                en.PositionX = en.EnemyInvader.Location.X;
                en.PositionY = en.EnemyInvader.Location.Y;
                en.EnemyInvader.Location = new Point(en.PositionX, en.PositionY + 1);
                for (int i = 0; i < enemies.Count - 1; i++)
                {
                    if (en.PositionY >= 400)
                    {
                        Life.LifeCount -= 1;
                        if (Life.LifeCount < 1)
                        {
                            Life.LifeCount = 0;
                        }
                        en.EnemyInvader.Location = new Point(en.PositionX, randomY.Next(10, 100));
                    }
                }

            }
        }
    }
}
