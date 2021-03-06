namespace Game.Classes
{
    using Enemies;
    using Game.Classes.Characters;
    public class InvadersAttackCollision
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

        public bool EnemyShotPlayerShipCollision(PlayerShip shipPlayer,BulletEnemy enemyShot)
        {
            if (shipPlayer.Ship.Location.X <= enemyShot.EnemyBullet.Location.X &&
                shipPlayer.Ship.Location.X + shipPlayer.Ship.Width >= (enemyShot.EnemyBullet.Location.X) &&
                shipPlayer.Ship.Location.Y + 20 <= enemyShot.EnemyBullet.Location.Y)
            {
                return true;
            }
            return false;
        }
    }
}
