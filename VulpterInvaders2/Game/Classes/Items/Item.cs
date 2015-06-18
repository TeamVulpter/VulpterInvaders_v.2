using System;

namespace Game.Classes.Items
{
    using Classes;
    class Item : GameObject
    {
        private ItemType itemType;

        public Item(int positionX, int positionY) : base(positionX, positionY)
        {
        }

        public void CreateItem()
        {
            Random rnd = new Random();
            int randomCol = rnd.Next(0, this.PositionX - 1);
            int randomRow = rnd.Next(0, this.PositionY - 1);
            this.itemType = (ItemType) Enum.Parse(typeof(ItemType), rnd.Next(1, 4).ToString());
        }

        public int ItemType { get; set; }

    }
}
