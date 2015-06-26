namespace Game.Classes.Enemies
{
    using System.Windows.Forms;
    public class EnemyShip: GameObject
    {
        private Panel enemyInvader;
        public EnemyShip(int positionX, int positionY, Panel enemyInvader) 
            :base(positionX, positionY)
        {
            this.enemyInvader = enemyInvader;
        }
       
    }
}
