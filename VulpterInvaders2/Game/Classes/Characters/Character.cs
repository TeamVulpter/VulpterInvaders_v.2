using Game.Interfaces;

namespace Game.Classes.Characters
{
    public abstract class Character : GameObject, IMovable
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
