using System;
using System.Windows.Forms;

namespace Game.Classes.Characters
{
    public class PlayerShip : Character
    {
        private PictureBox playerShip;
        public PlayerShip(int positionX, int positionY, PictureBox playerShip)
            : base(positionX, positionY)
        {
            this.playerShip = playerShip;
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
            throw new NotImplementedException();
        }
    }
}
