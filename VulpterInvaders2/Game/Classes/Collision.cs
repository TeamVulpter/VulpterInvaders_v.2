using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Classes.Enemies;

namespace Game.Classes
{
    public class Collision
    {
        public bool EnemyPlayerBullet(GameObject bullet, EnemyShip enemy)
        {
            if (((bullet.PositionX >= enemy.PositionX &&
                        bullet.PositionX <= (enemy.PositionX + enemy.Width)) &&
                   (bullet.PositionY >= enemy.EnemyInvader.Location.Y &&
                        bullet.PositionY <= (enemy.EnemyInvader.Location.Y + 10))))
            {
                return true;

            }
            return false;
        }
    }
}
