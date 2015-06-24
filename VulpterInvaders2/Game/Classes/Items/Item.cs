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
        Random rnd = new Random();

        public Item(int positionX, int positionY, ItemType type) : base(positionX, positionY)
        {
            this.ItemType = type;
            this.GenerateBonus();
            this.InitializePictureBox();
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

        private void InitializePictureBox()
        {
            this.Picture = new PictureBox();
            int randomX = this.rnd.Next(1, VulpterInvadersGame.ActiveForm.Width);
            int randomY = this.rnd.Next(1, VulpterInvadersGame.ActiveForm.Height);

            // Set the location and size of the PictureBox control. 
            this.Picture.Location = new System.Drawing.Point(randomX, randomY);
            this.Picture.Size = new System.Drawing.Size(75, 75);
            this.Picture.TabStop = false;
            this.Picture.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
