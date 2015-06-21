using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game.Classes.Characters;

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
