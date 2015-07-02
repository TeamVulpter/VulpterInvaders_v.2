using System.Linq;

namespace Game.Classes.Factory
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using Interfaces;

    using Items;

    public class ItemsFactory
    {
        private Random rnd = new Random();
        private List<int> rndX = new List<int>();
        private List<int> rndY = new List<int>();
        private IMap map;
        private int maxRandomX;
        private int maxRandomY;

        public List<Item> CreateItems(int numbersOfItems, List<PictureBox> pic, IMap map)
        {
            List<Item> items = new List<Item>();
            this.map = map;

            for (int i = 0; i < numbersOfItems; i++)
            {
                int randomItem = rnd.Next(1, 5);
                this.maxRandomX = this.map.Right - pic[i].Width;
                this.maxRandomY = this.map.Down - pic[i].Height;
                ItemType type = (ItemType) Enum.Parse(typeof (ItemType), randomItem.ToString());

                items.Add(new Item(
                                    this.GenerateRandomX(this.map.Left, this.maxRandomX),
                                    this.GenerateRandomY(this.map.Top, this.maxRandomY), 
                                    type, 
                                    pic[i]
                                   )
                         );
            }
            return items;
        }

        //create random x position
        private int GenerateRandomX(int minX, int maxX)
        {
            int randomX = rnd.Next(minX, maxX);
            var randX = rndX.Any(x => x == randomX);
            if (randX)
            {
                return this.GenerateRandomX(this.map.Left, this.maxRandomX);
            }
            this.rndX.Add(randomX);
            return randomX;
        }

        //create random y position
        private int GenerateRandomY(int minY, int maxY)
        {
            int randomY = rnd.Next(minY, maxY);
            var randY = rndY.Any(y => y == randomY);
            if (randY)
            {
                return this.GenerateRandomY(this.map.Top, this.maxRandomY);
            }
            this.rndY.Add(randomY);
            return randomY;
        }
    }
}
