namespace Game.Interfaces
{
    using System.Collections.Generic;
    using Classes;
    using Classes.Enemies;

    public interface IShootableEnemyBullet
    {
        void EnemyShoot(BulletEnemy enemyShot, IList<EnemyShip> enemies);
    }
}
