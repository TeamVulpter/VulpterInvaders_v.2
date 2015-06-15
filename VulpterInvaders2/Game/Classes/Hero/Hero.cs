namespace Game.Classes.Hero
{
    using Interfaces;
    public abstract class Hero : IHero
    {
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
    }
}
