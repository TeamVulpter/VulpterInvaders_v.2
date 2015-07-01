namespace Game.Classes
{
    using System.Windows.Forms;

    public class BulletPlayer :Bullet
    {
        //TODO
        //private Panel bulletPanel;

        public BulletPlayer(Panel bulletPanel)
            :base(bulletPanel.Location.X, bulletPanel.Location.Y)
        {
            this.BulletPanel = bulletPanel;
            BulletPanel.Visible = false;
            this.IsActive = false;
        }

        public Panel BulletPanel { get; set; }

        public override void Start()
        {
            if (this.IsActive)
            {
                return;
            }

            IsActive = true;
            BulletPanel.Visible = true;
        }

        public override void Stop()
        {
            this.IsActive = false;
            BulletPanel.Visible = false;
        }
    }
}
