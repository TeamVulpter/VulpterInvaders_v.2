namespace Game.Classes.Map
{
    using System.Collections.Generic;
    using Interfaces;
    public class Map : IMap
    {
        private int top;
        private int down;
        private int left;
        private int right;

        Dictionary<string, int> location = new Dictionary<string, int>();

        public Map(int top, int down, int left, int right)
        {
            this.Top = top;
            this.Down = down;
            this.Left = left;
            this.Right = right;
            MapLacation();
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

        public void MapLacation()
        {
            this.location.Add("top", this.Top);
            this.location.Add("down", this.Down);
            this.location.Add("left", this.Left);
            this.location.Add("right", this.Right);
        }
    }
}
