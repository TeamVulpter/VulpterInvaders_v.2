﻿namespace Game.Classes.Items
{
    using System;
    class Bonus : Item
    {
        private int bonusHealth = 0;
        private int bonusScore = 0;
        private int bonusLife = 0;

        public Bonus(int positionX, int positionY, ItemType type) : base(positionX, positionY, type)
        {
            this.ItemType = type;
            this.GenerateBonus();
        }

        public int BonusHealth
        {
            get { return bonusHealth; }
            set { this.bonusHealth = value; }
        }
        public int BonusScore
        {
            get { return this.bonusScore; }
            set { this.bonusScore = value; }
        }
        public int BonusLife
        {
            get { return this.bonusLife; }
            set { this.bonusLife = value; }
        }

        public void GenerateBonus()
        {
            Random rnd = new Random();
            int randomBonus = rnd.Next(0, 150);
            if (this.ItemType.ToString() == "BonusHealth")
            {
               this.BonusHealth += randomBonus;
            }
            else if (this.ItemType.ToString() == "BonusScore")
            {
                this.BonusScore += randomBonus;
            }
            else if (this.ItemType.ToString() == "BonusLife")
            {
                this.BonusLife += randomBonus;
            }
        }
    }
}
