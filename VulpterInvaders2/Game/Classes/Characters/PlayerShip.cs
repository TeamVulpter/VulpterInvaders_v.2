namespace Game.Classes.Characters
{
    using System.Drawing;
    using System.Windows.Forms;
    public class PlayerShip : Character
    {
        private PictureBox playerShip;
        public PlayerShip(int positionX, int positionY, PictureBox playerShip)
            : base(positionX, positionY)
        {
            
            this.Ship = playerShip;
        }

        public PictureBox Ship { get; set; }

        public void MoveLeft()
        {
            Ship.Location = new Point(Ship.Location.X - 10, Ship.Location.Y);
        }

        public void MoveRight()
        {
            Ship.Location = new Point(Ship.Location.X + 10, Ship.Location.Y);
        }

        public bool StopAtMax(int positionOfPlayer, int maxValue)
        {
            if (positionOfPlayer > maxValue)
            {
                return true;
            }
            return false;
        }

        public bool StopAtMin(int positionOfPlayer, int minValue)
        {
            if (positionOfPlayer < minValue)
            {
                return true;
            }
            return false;
        }
    }
}
