namespace Game.Classes
{
    using System.Windows.Forms;

    public class BulletEnemy : Bullet
    {
        public BulletEnemy(Panel bulletEnemy)
            : base(bulletEnemy.Location.X, bulletEnemy.Location.Y)
        {
            this.EnemyBullet = bulletEnemy;
            this.EnemyBullet.Visible = false;
            this.IsActive = false;
        }

        public Panel EnemyBullet { get; set; }

        public override void Start()
        {
            if (this.IsActive)
            {
                return;
            }

            this.IsActive = true;
            this.EnemyBullet.Visible = true;
        }

        public override void Stop()
        {
            this.IsActive = false;
            this.EnemyBullet.Visible = false;
        }
    }
}
