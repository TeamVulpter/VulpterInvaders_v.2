﻿namespace Game.Classes.Factory
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

        public List<Item> CreateItems(int numbersOfItems, List<PictureBox> pic, IMap map)
        {
            List<Item> items = new List<Item>();
            for (int i = 0; i < numbersOfItems; i++)
            {
                int randomItem = rnd.Next(1, 5);
                ItemType type = (ItemType) Enum.Parse(typeof (ItemType), randomItem.ToString());
                items.Add(new Item(
                                    this.GenerateRandomX(map.Left, map.Right-pic[i].Width), 
                                    this.GenerateRandomY(map.Top, map.Down-pic[i].Height), 
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
            Again:
            int randomX = rnd.Next(minX, maxX);
            foreach (int x in rndX)
            {
                if (x == randomX)
                {
                    goto Again;
                }
            }
            this.rndX.Add(randomX);
            return randomX;
        }

        //create random y position
        private int GenerateRandomY(int minY, int maxY)
        {
            Again:
            int randomY = rnd.Next(minY, maxY);
            foreach (int y in rndY)
            {
                if (y == randomY)
                {
                    goto Again;
                }
            }
            this.rndY.Add(randomY);
            return randomY;
        }
    }
}