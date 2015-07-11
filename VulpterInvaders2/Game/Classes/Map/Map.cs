namespace Game.Classes.Map
{
    using System;

    using Interfaces;

    public class Map : IMap
    {
        private int top;
        private int left;
        private int down;
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
            get
            {
                return this.top;
            }

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
            get
            {
                return this.down;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("down", "Value for down of field, cannot be negative!");
                }

                this.down = value;
            }
        }

        public int Left
        {
            get
            {
                return this.left;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("left", "Value for left of field, cannot be negative!");
                }

                this.left = value;
            }
        }

        public int Right
        {
            get
            {
                return this.right;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("right", "Value for right of field, cannot be negative!");
                }

                this.right = value;
            }
        }
    }
}
