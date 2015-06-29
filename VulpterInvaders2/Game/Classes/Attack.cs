﻿namespace Game.Classes
{
    using System.Collections.Generic;
    using System.Drawing;

    using Enemies;
    using Interfaces;

    public class Attack : IAttack
    {
        public void UpdateAttack(IList<EnemyShip> enemies)
        {
            foreach (var en in enemies)
            {
                en.PositionX = en.EnemyInvader.Location.X;
                en.PositionY = en.EnemyInvader.Location.Y;
                en.EnemyInvader.Location = new Point(en.PositionX, en.PositionY + 1);
                if (en.PositionY >= 400)
                {
                    en.EnemyInvader.Location = new Point(en.PositionX, 20);
                }
            }
        }
    }
}
