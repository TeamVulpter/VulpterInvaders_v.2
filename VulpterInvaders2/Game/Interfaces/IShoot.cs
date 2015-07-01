using Game.Classes;

namespace Game.Interfaces
{
    public interface IShoot
    {
        void Shoot(BulletPlayer bullet);

        void UpdateShots(BulletPlayer bullet);
    }
}
