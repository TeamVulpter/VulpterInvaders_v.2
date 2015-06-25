namespace Game.Classes.Matrix
{
    using Interfaces;
    public class Map : IMap
    {
        private int top;
        private int down;
        private int left;
        private int right;

        public Map(int top, int down, int left, int right)
        {
            this.Top = top;
            this.Down = down;
            this.Left = left;
            this.Right = right;
        }

        public int Top
        {
            get { return this.top; }
            set { this.top = value; }
        }
        public int Down
        {
            get { return this.down; }
            set { this.down = value; }
        }
        public int Left
        {
            get { return this.left; }
            set { this.left = value; }
        }
        public int Right
        {
            get { return this.right; }
            set { this.right = value; }
        }

        public int[] MapLacation()
        {
            int[] location = new []
            {
                this.Top,
                this.Left,
                this.Down,
                this.Right
            };
            return location;
        }
    }
}
