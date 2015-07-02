namespace Game.Classes.Characters
{
    using System.Windows.Forms;

    public class PlayerShip : Character
    {
        public PlayerShip(PictureBox playerShip)
            : base(playerShip.Location.X, playerShip.Location.Y)
        {
            this.Ship = playerShip;
        }

        public PictureBox Ship { get; set; }

        public override void MoveLeft()
        {
            Ship.Left -= 10;
        }

        public override void MoveRight()
        {
            Ship.Left += 10;
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
