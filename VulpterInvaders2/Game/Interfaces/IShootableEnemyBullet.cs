using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Classes;
using Game.Classes.Enemies;

namespace Game.Interfaces
{
    public interface IShootableEnemyBullet
    {
        void EnemyShoot(BulletEnemy enemyShot, IList<EnemyShip> enemies);
    }
}
