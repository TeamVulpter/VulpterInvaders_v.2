namespace Game.Classes.Items
{
    using System;
    using System.Windows.Forms;
    using Classes;

    public class Item : GameObject
    {
        private ItemType itemType;
        private PictureBox picture;
        private int bonusHealth = 0;
        private int bonusScore = 0;
        private int bonusLife = 0;

        public Item(int positionX, int positionY, ItemType type, PictureBox picture) : base(positionX, positionY)
        {
            this.ItemType = type;
            this.Picture = picture;
            this.GenerateBonus();
        }

        public PictureBox Picture
        {
            get { return this.picture; }
            set { this.picture = value;}
        }
        protected ItemType ItemType
        {
            get { return this.itemType; }
            set { this.itemType = value; }
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
