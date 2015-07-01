using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.Classes
{
    public class BulletEnemy : GameObject
    {
        public BulletEnemy(Panel bulletEnemy)
            : base(bulletEnemy.Location.X, bulletEnemy.Location.Y)
        {
            this.EnemyBullet = bulletEnemy;
            EnemyBullet.Visible = false;
            this.IsActive = false;
        }

        public Panel EnemyBullet { get; set; }
        public bool IsActive { get; set; }

        public void Start()
        {
            if (this.IsActive)
            {
                return;
            }

            IsActive = true;
            EnemyBullet.Visible = true;
        }

        public void Stop()
        {
            this.IsActive = false;
            EnemyBullet.Visible = false;
        }
    }
}
