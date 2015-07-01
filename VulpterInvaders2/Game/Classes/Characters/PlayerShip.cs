namespace Game.Classes.Characters
{
    using System.Drawing;
    using System.Windows.Forms;

    public class PlayerShip : Character
    {
        private PictureBox playerShip;

        public PlayerShip(PictureBox playerShip)
            : base(playerShip.Location.X, playerShip.Location.Y)
        {
            
            this.Ship = playerShip;
        }

        public PictureBox Ship { get; set; }

        public override void MoveLeft()
        {
            Ship.Location = new Point(Ship.Location.X - 10, Ship.Location.Y);
        }

        public override void MoveRight()
        {
            Ship.Location = new Point(Ship.Location.X + 10, Ship.Location.Y);
        }

        public override bool StopAtMax(int positionOfPlayer, int maxValue)
        {
            if (positionOfPlayer > maxValue)
            {
                return true;
            }
            return false;
        }

        public override bool StopAtMin(int positionOfPlayer, int minValue)
        {
            if (positionOfPlayer < minValue)
            {
                return true;
            }
            return false;
        }
    }
}
