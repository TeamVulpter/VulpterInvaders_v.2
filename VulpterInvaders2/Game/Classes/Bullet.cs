namespace Game.Classes
{
    using System.Windows.Forms;

    public class Bullet :GameObject
    {
        private Panel bulletPanel;

        public Bullet(Panel bulletPanel)
            :base(bulletPanel.Location.X, bulletPanel.Location.Y)
        {
            this.BulletPanel = bulletPanel;
            BulletPanel.Visible = false;
            this.IsActive = false;
        }

        public Panel BulletPanel { get; set; }
        public bool IsActive { get; set; }

        public void Start()
        {
            if (this.IsActive)
            {
                return;
            }

            IsActive = true;
            BulletPanel.Visible = true;
        }

        public void Stop()
        {
            this.IsActive = false;
            BulletPanel.Visible = false;
        }
    }
}
