namespace Game.Classes.Characters
{
    using Interfaces;
    public abstract class Character : GameObject, ICharacter
    {
        private string name;
        private int health;
        private int lives;
        private int scores;

        protected Character(int positionX, int positionY)
            : base(positionX, positionY)
        {
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    //TODO throw exception or send message
                }
                this.name = value.Trim();
            }
        }
        public int Health
        {
            get { return this.health; }
            set
            {
                if (value < 0)
                {
                    //TODO throw exception or send message
                }
                this.health = value;
            }
        }
        public int Lives
        {
            get { return this.lives; }
            set
            {
                if (value < 0)
                {
                    //TODO throw exception or send message
                }
                this.lives = value;
            }
        }
        public int Scores
        {
            get { return this.scores; }
            set
            {
                if (value < 0)
                {
                    //TODO throw exception or send message
                }
                this.scores = value;
            }
        }
        //Add hero
        public void CreateHero(int positionX, int positionY, string heroName)
        {
            this.Name = heroName;
            this.Health = 150;
            this.Lives = 3;
        }
        //Kill hero
        public void KillHero()
        {
            this.Lives = 0;
            this.Health = 0;
        }
        //add health to hero
        public abstract void AddHealth(int points);
        //remove health from hero
        public abstract void RemoveHealth(int points);
        //add lives to hero
        public abstract void AddLives(int life);
        //remove lives from hero
        public abstract void RemoveLives(int life);
        //add bonus scores to hero
        public abstract void AddScores(int score);
        //remove bonus score from hero
        public abstract void RemoveScores(int score);

        public abstract void Mooving(int x, int y);
    }
}
