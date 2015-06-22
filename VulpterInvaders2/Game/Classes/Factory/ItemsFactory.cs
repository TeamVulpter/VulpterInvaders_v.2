namespace Game.Classes.Factory
{
    using System;
    using System.Collections.Generic;
    using Items;
    public class ItemsFactory
    {
        //generation bonus
        //this.item = new Item(300, 300, ItemType.BonusLife);
        Random rnd = new Random();

        public List<Item> CreateItems(int numbersOfItems)
        {
            List<Item> items = new List<Item>();
            
            for (int i = 0; i < numbersOfItems; i++)
            {
                int randomItem = rnd.Next(0, 4);

                items.Add(new Item(GenerateRandomX(500), GenerateRandomY(500), ItemType.BonusHealth));
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
