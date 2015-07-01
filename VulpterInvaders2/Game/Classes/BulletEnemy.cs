﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.Classes
{
    public class BulletEnemy : Bullet
    {
        public BulletEnemy(Panel bulletEnemy)
            : base(bulletEnemy.Location.X, bulletEnemy.Location.Y, bulletEnemy)
        {
            this.EnemyBullet = bulletEnemy;
            EnemyBullet.Visible = false;
            this.IsActive = false;
        }

        public Panel EnemyBullet { get; set; }

        public override void Start()
        {
            if (this.IsActive)
            {
                return;
            }

            IsActive = true;
            EnemyBullet.Visible = true;
        }

        public override void Stop()
        {
            this.IsActive = false;
            EnemyBullet.Visible = false;
        }
    }
}