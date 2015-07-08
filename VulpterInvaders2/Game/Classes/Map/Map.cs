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
                    throw new ArgumentOutOfRangeException("top", 
                        "Value for top of field, cannot be negative!");
                }

                this.top = value;
            }
        }
        public int Down
        {
            get { return this.down; }
            set
            {
                if (value > 510)
                {
                    throw new ArgumentOutOfRangeException("top",
                        "The amount of the upper limit can not be greater than the standard");
                }

                this.down = value;
            }
        }
        public int Left
        {
            get { return this.left; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("top",
                        "Value for top of field, cannot be negative!");
                }

                this.left = value;
            }
        }

        public int Right
        {
            get { return this.right; }
            set
            {
                if (value > 510)
                {
                    throw new ArgumentOutOfRangeException("top",
                        "The amount of the upper limit can not be greater than the standard");
                }

                this.right = value;
            }
        }

    }
}
