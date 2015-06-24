using System.Windows.Forms;

namespace Game.Classes
{
    public class Bullet :GameObject
    {
        private Panel bulletPanel;

        public Bullet(int positionX, int positionY, Panel bulletPanel)
            :base(positionX, positionY)
        {
            this.BulletPanel = bulletPanel;
            BulletPanel.Visible = false;
            this.IsActive = false;
        }

        public void Start()
        {
            if (IsActive)
            {
                return;
            }
            IsActive = true;
            BulletPanel.Visible = true;

        }

        public void Stop()
        {
            IsActive = false;
            BulletPanel.Visible = false;
        }

        public bool IsActive { get; set; }
        public Panel BulletPanel { get; set; }
    }
}
