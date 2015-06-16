namespace Game.Classes.Hero
{
    using Interfaces;
    public abstract class Hero : IHero
    {
        private Health health;
        private Score scores;
        private Life lives;

        private string name;
        private int positionX;
        private int positionY;

        public void CreateHero(int positionX, int positionY, string name)
        {
            throw new System.NotImplementedException();
        }

        public void CreateHero()
        {
            throw new System.NotImplementedException();
        }

        public void KillHero()
        {
            throw new System.NotImplementedException();
        }

        public abstract void AddHealth();
        public abstract void RemoveHealth();

        public abstract void AddLives();
        public abstract void RemoveLives();

        public abstract void AddScores();
        public abstract void RemoveScores();

        public abstract void Mooving(int x, int y);
    }
}
