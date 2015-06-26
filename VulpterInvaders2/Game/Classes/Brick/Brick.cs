namespace Game.Classes.Brick
{
    using System.Windows.Forms;

    public class Brick : GameObject
    {
        private PictureBox brickSingle;

        public Brick(int positionX, int positionY, PictureBox brickSingle)
            : base(positionX, positionY)
        {
            this.BrickSingle = brickSingle;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public PictureBox BrickSingle { get; set; }
    }
}
