using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes.Characters
{
    public abstract class Character:GameObject
    {
        protected Character(int positionX, int positionY)
            : base(positionX, positionY)
        {

        }

        public abstract void MoveLeft();


        public abstract void MoveRight();


        public abstract bool StopAtMax(int positionOfPlayer, int maxValue);


        public abstract bool StopAtMin(int positionOfPlayer, int minValue);

       
    }
}
