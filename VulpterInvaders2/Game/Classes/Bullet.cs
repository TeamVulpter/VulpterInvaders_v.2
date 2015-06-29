namespace Game.Classes
{
    using System.Windows.Forms;
    public class Bullet :GameObject
    {
        private Panel bulletPanel;

        public Bullet(Panel bulletPanel)
            :base(bulletPanel.Location.X, bulletPanel.Location.Y)
        {
            this.bulletPanel = bulletPanel;
            bulletPanel.Visible = false;
            this.IsActive = false;
        }

        public void Start()
        {
            if (IsActive)
            {
                return;
            }
            IsActive = true;
            bulletPanel.Visible = true;

        }

        public void Stop()
        {
            IsActive = false;
            bulletPanel.Visible = false;
        }

        public bool IsActive { get; set; }
    }
}
