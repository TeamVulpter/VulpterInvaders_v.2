using System.Drawing;

namespace Game.Classes
{
    using Interfaces;
    using System.Collections.Generic;
    using Game.Classes.Enemies;

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
