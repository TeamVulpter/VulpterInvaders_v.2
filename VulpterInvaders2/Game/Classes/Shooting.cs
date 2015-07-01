namespace Game.Classes
{
    using System.Drawing;
    using Interfaces;

    public class Shooting :IShoot
    {
        public void Shoot(BulletPlayer bullet)
        {
            bullet.BulletPanel.Location = new Point(bullet.PositionX, bullet.PositionY - 10);
            bullet.Start();
        }
    }
}
