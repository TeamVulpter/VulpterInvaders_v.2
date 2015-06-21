namespace Game.Classes.Items
{
    using Classes;
    class Item : GameObject
    {
        private ItemType itemType;

        public Item(int positionX, int positionY, ItemType type) : base(positionX, positionY)
        {
            this.ItemType = type;
        }

        protected ItemType ItemType { get; set; }

    }
}
