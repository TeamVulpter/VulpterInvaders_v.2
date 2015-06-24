using System.Windows.Forms;

namespace Game.Classes.Factory
{
    using System;
    using System.Collections.Generic;
    using Items;
    public class ItemsFactory
    {
        Random rnd = new Random();

        public List<Item> CreateItems(int numbersOfItems)
        {
            List<Item> items = new List<Item>();
            for (int i = 1; i <= numbersOfItems; i++)
            {
                int randomItem = rnd.Next(1, 4);
                ItemType type = (ItemType) Enum.Parse(typeof (ItemType), randomItem.ToString());
                items.Add(new Item(GenerateRandomX(500), GenerateRandomY(500), type));
            }
            return items;
        }

        //create random x position
        private int GenerateRandomX(int maxFieldX)
        {
            int randomX = rnd.Next(0, maxFieldX);
            return randomX;
        }

        //create random y position
        private int GenerateRandomY(int maxFieldY)
        {
            int randomY = rnd.Next(0, maxFieldY);
            return randomY;
        }
    }
}
