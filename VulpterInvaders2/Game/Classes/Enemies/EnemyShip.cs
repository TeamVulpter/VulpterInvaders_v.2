using System.Windows.Forms;

namespace Game.Classes.Enemies
{
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
