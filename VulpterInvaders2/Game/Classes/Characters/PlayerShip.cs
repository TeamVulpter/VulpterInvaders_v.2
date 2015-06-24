using System.Windows.Forms;

namespace Game.Classes.Characters
{
    public class PlayerShip : Character
    {
        private PictureBox playerShip;
        public PlayerShip(int positionX, int positionY, PictureBox playerShip)
            : base(positionX, positionY)
        {
            this.Ship = playerShip;
        }

        public PictureBox Ship { get; set; }
    }
}
