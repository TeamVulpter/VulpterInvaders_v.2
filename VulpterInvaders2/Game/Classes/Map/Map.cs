using System;

namespace Game.Classes.Map
{
    using Interfaces;

    public class Map : IMap
    {
        private int top;
        private int down;
        private int left;
        private int right;

        public Map(int top, int left, int down, int right)
        {
            this.Top = top;
            this.Down = down;
            this.Left = left;
            this.Right = right;
        }

        public int Top
        {
            get { return this.top; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("top", "Value for top of field, cannot be negative!");
                }
                this.top = value;
            }
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

    }
}
