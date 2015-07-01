namespace Game.Classes.Enemies
{
    using System.Windows.Forms;

    public class EnemyShip: GameObject
    {
        private Panel enemyInvader;
        public EnemyShip(Panel enemyInvader)
            : base(enemyInvader.Location.X, enemyInvader.Location.Y)
        {
            this.EnemyInvader = enemyInvader;
            this.Width = enemyInvader.Width;
            this.Height = enemyInvader.Height;
        }

        public Panel EnemyInvader { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }
     
    }
}
