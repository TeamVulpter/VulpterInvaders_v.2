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
        }

        public Panel EnemyInvader { get; set; }
     
    }
}
