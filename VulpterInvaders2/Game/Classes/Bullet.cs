namespace Game.Classes
{
    using Game.Interfaces;

    public abstract class Bullet : GameObject, IShootable
    {
        protected Bullet(int positionX, int positionY)
            : base(positionX, positionY)
        {
        }

        public bool IsActive { get; set; }

        public abstract void Start();

        public abstract void Stop();

    }
}
