namespace Game.Classes.Items
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    using Classes;

    using Exception;

    using Interfaces;

    public class Item : GameObject, IItem
    {
        private ItemType itemType;
        private PictureBox picture;
        private int bonusHealth = 0;
        private int bonusScore = 0;
        private int bonusLife = 0;
        private int removeBonus = 0;
        protected Random rnd = new Random();

        public Item(int positionX, int positionY, ItemType type, PictureBox pic) : base(positionX, positionY)
        {
            this.ItemType = type;
            this.GenerateBonus();
            this.InitializePictureBox(pic);
        }

        public PictureBox Picture
        {
            get { return this.picture; }
            set { this.picture = value;}
        }

        public ItemType ItemType
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

        public int RemoveBonus
        {
            get { return this.removeBonus; }
            set { this.removeBonus = value; }
        }

        private void GenerateBonus()
        {
            if (this.ItemType.ToString() == "RemoveBonus")
            {
                int randomBonus = this.rnd.Next(0, 4);
                this.RemoveBonus -= randomBonus;
            }   
            else if (this.ItemType.ToString() == "BonusHealth")
            {
                int randomBonus = this.rnd.Next(0, 100);
                this.BonusHealth += randomBonus;
            }
            else if (this.ItemType.ToString() == "BonusScore")
            {
                int randomBonus = this.rnd.Next(0, 50);
                this.BonusScore += randomBonus;
            }
            else if (this.ItemType.ToString() == "BonusLife")
            {
                int randomBonus = this.rnd.Next(0, 4);
                this.BonusLife += randomBonus;
            }  
        }

        private void InitializePictureBox(PictureBox pic)
        {
            this.Picture = pic;
            this.Picture.Location = new Point(this.PositionX, this.PositionY);
            this.Picture.Size = new Size(30, 26);
            this.Picture.Margin = new Padding(0, 0, 0, 0);
            this.Picture.TabIndex = 30;
            this.Picture.TabStop = false;

            switch (this.ItemType)
            {
                case ItemType.BonusHealth:
                    this.Picture.ImageLocation = @"../../Resources/LifeBonus.png";
                    break;
                case ItemType.BonusLife:
                    this.Picture.ImageLocation = @"../../Resources/RedPresent.png";
                    break;
                case ItemType.BonusScore:
                    this.Picture.ImageLocation = @"../../Resources/BlueGear.png";
                    break;
                case ItemType.RemoveBonus:
                    this.Picture.ImageLocation = @"../../Resources/BadGear.png";
                    break;
                default:
                    throw new InvalidPictureException();
            }
        }
    }
}                  