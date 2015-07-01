using Game.Classes;

namespace Game.Interfaces
{
    public interface IShoot
    {
        void Shoot(Bullet bullet);

        void UpdateShots(Bullet bullet);
    }
}
