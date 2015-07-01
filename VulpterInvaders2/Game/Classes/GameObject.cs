namespace Game.Classes
{
    public abstract class GameObject
    {
        protected GameObject(int positionX, int positionY)
        {
            this.PositionX = positionX;
            this.PositionY = positionY;
        }

        public int PositionX { get; set; }

        public int PositionY { get; set; }
    }
}
