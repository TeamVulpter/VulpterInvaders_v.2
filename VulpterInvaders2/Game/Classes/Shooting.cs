using System.Drawing;

namespace Game.Classes
{
    using System;
    using Interfaces;
    public class Shooting :IShootPlayer
    {
        public void Shoot(BulletPlayer bullet)
        {
            bullet.BulletPanel.Location = new Point(bullet.PositionX, bullet.PositionY - 10);
            bullet.Start();
            if (bullet.PositionY <= 20)
            {
                bullet.BulletPanel.Visible = false;
            }
           
        }

    }
}
