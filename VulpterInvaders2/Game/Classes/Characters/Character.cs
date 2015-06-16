namespace Game.Classes.Characters
{
    using Interfaces;
    public abstract class Character : GameObject, ICharacter
    {
        //private Health health;
        //private Score scores;
        //private Life lives;

        private string name;


        protected Character(int x, int y)
            : base(x, y)
        {

        }
        public void CreateHero(int positionX, int positionY, string name)
        {
            Health.HelthCount = 150;
            Life.LifeCount = 3;
        }

        public void CreateHero()
        {
            throw new System.NotImplementedException();
        }

        public void KillHero()
        {
            Life.LifeCount = 0;
            Health.HelthCount = 0;
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
