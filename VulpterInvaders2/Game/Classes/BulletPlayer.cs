namespace Game.Classes
{
    using System.Windows.Forms;

    public class BulletPlayer :Bullet
    {
        public BulletPlayer(Panel bulletPanel)
            :base(bulletPanel.Location.X, bulletPanel.Location.Y)
        {
            this.BulletPanel = bulletPanel;
            this.BulletPanel.Visible = false;
            this.IsActive = false;
        }

        public Panel BulletPanel { get; set; }

        public override void Start()
        {
            if (this.IsActive)
            {
                return;
            }

            this.IsActive = true;
            this.BulletPanel.Visible = true;
        }

        public override void Stop()
        {
            this.IsActive = false;
            this.BulletPanel.Visible = false;
        }
    }
}
