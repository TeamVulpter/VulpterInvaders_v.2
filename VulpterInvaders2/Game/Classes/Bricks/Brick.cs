namespace Game.Classes.Bricks
{
    using System.Windows.Forms;

    public class Brick : GameObject
    {
        private PictureBox brickSingle;

        public Brick(PictureBox brickSingle)
            : base(brickSingle.Location.X, brickSingle.Location.Y)
        {
            this.BrickSingle = brickSingle;
        }
       

        public PictureBox BrickSingle
        {
            get
            {
                return this.brickSingle;
            }

            private set
            {
                this.brickSingle = value;
            }
        }
    }
}
