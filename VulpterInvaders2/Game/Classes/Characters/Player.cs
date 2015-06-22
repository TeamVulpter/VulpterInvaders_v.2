using System.Windows.Forms;

namespace Game.Classes.Characters
{
    public class Player : Character
    {
        private PictureBox hero;
        public Player(int positionX, int positionY, PictureBox hero)
            : base(positionX, positionY)
        {
            this.Hero = hero;
        }

        public PictureBox Hero { get; set; }
    }
}
