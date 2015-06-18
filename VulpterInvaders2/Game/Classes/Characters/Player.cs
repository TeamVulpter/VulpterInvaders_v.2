using System.Windows.Forms;

namespace Game.Classes.Characters
{
    public class Player : Character
    {
        private PictureBox hero;
        public Player(int positionX, int positionY, PictureBox hero)
            : base(positionX, positionY)
        {
            this.hero = hero;
        }

        public override void AddHealth(int points)
        {
            if (points < 0)
            {
                //TODO add exception or message;
                return;
            }
            this.Health += points;
        }
        
        public override void RemoveHealth(int points)
        {
            if (points < 0)
            {
                //TODO add exception or message;
                return;
            }
            this.Health -= points;
        }

        public override void AddLives(int life)
        {
            if (life < 0)
            {
                //TODO add exception or message;
                return;
            }
            this.Lives += life;
        }

        public override void RemoveLives(int life)
        {
            if (life < 0)
            {
                //TODO add exception or message;
                return;
            }
            this.Lives -= life;
        }

        public override void AddScores(int score)
        {
            if (score < 0)
            {
                //TODO add exception or message;
                return;
            }
            this.Scores += score;
        }

        public override void RemoveScores(int score)
        {
            if (score < 0)
            {
                //TODO add exception or message;
                return;
            }
            this.Scores -= score;
        }

        public override void Mooving(int x, int y)
        {
            throw new System.NotImplementedException();
        }
    }
}
