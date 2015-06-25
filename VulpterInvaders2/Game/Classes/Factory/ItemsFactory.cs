﻿namespace Game.Classes.Factory
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Items;
    using Map;

    public class ItemsFactory
    {
        Random rnd = new Random();

        public List<Item> CreateItems(int numbersOfItems, List<PictureBox> pic, Map map)
        {
            List<Item> items = new List<Item>();
            for (int i = 0; i < numbersOfItems; i++)
            {
                int randomItem = rnd.Next(1, 4);
                ItemType type = (ItemType) Enum.Parse(typeof (ItemType), randomItem.ToString());
                items.Add(new Item(
                                    GenerateRandomX(map.Left, map.Right-pic[i].Width), 
                                    GenerateRandomY(map.Top, map.Down-pic[i].Height), 
                                    type, pic[i]
                                   )
                         );
            }
            return items;
        }

        //create random x position
        private int GenerateRandomX(int minX, int maxX)
        {
            int randomX = rnd.Next(minX, maxX);
            return randomX;
        }

        //create random y position
        private int GenerateRandomY(int minY, int maxY)
        {
            int randomY = rnd.Next(minY, maxY);
            return randomY;
        }
    }
}
