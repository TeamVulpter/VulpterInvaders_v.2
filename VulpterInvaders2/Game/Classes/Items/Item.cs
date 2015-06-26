namespace Game.Classes.Items
{
    using System;
    using System.Windows.Forms;
    using System.Drawing;
    using Classes;

    public class Item : GameObject
    {
        private ItemType itemType;
        private PictureBox picture;
        private int bonusHealth = 0;
        private int bonusScore = 0;
        private int bonusLife = 0;
        Random rnd = new Random();

        public Item(int positionX, int positionY, ItemType type, PictureBox pic) : base(positionX, positionY)
        {
            this.ItemType = type;
            this.GenerateBonus();
            this.InitializePictureBox(pic);
        }

        protected PictureBox Picture
        {
            get { return this.picture; }
            set { this.picture = value;}
        }
        protected ItemType ItemType
        {
            get { return this.itemType; }
            set { this.itemType = value; }
        }
        protected int BonusHealth
        {
            get { return bonusHealth; }
            set { this.bonusHealth = value; }
        }
        protected int BonusScore
        {
            get { return this.bonusScore; }
            set { this.bonusScore = value; }
        }
        protected int BonusLife
        {
            get { return this.bonusLife; }
            set { this.bonusLife = value; }
        }

        private void GenerateBonus()
        {
            int randomBonus = this.rnd.Next(0, 150);
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

        private void InitializePictureBox(PictureBox pic)
        {
            this.Picture = pic;
            this.Picture.Location = new Point(this.PositionX, this.PositionY);
            this.Picture.Size = new Size(30, 26);
            this.Picture.Margin = new Padding(0, 0, 0, 0);
            this.Picture.TabIndex = 30;
            this.Picture.TabStop = false;
            //
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
            }
        }
    }
}
