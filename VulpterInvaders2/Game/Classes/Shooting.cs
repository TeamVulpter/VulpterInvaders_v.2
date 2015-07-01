using System.Drawing;

namespace Game.Classes
{
    using System;
    using Interfaces;
    public class Shooting :IShoot
    {
        public void Shoot(Bullet bullet)
        {
            bullet.BulletPanel.Location = new Point(bullet.PositionX, bullet.PositionY - 10);
            bullet.Start();
           
        }

        public void UpdateShots(Bullet bullet)
        {
          
        }
    }
}
