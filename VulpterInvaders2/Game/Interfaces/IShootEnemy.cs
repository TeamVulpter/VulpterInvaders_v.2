namespace Game.Interfaces
{
    using System.Collections.Generic;
    using Classes;
    using Classes.Enemies;

    public interface IShootEnemy
    {
        void EnemyShoot(BulletEnemy enemyShot, IList<EnemyShip> enemies);
    }
}
