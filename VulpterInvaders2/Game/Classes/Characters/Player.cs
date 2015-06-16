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

        public override void AddHealth()
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveHealth()
        {
            throw new System.NotImplementedException();
        }

        public override void AddLives()
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveLives()
        {
            throw new System.NotImplementedException();
        }

        public override void AddScores()
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveScores()
        {
            throw new System.NotImplementedException();
        }

        public override void Mooving(int x, int y)
        {
            throw new System.NotImplementedException();
        }
    }
}
