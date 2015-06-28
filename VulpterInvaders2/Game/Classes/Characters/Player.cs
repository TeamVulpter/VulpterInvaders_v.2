namespace Game.Classes.Characters
{
    using System.Collections.Generic;
    using System.Windows.Forms;

    using Items;

    public class Player : Character
    {
        private PictureBox hero;

        public Player(int positionX, int positionY, PictureBox hero)
            : base(positionX, positionY)
        {
            this.Hero = hero;
        }

        public PictureBox Hero { get; set; }

        public IList<Item> GetItem(IList<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (((this.PositionX + 16 >= items[i].PositionX && this.PositionX + 16 <= (items[i].PositionX + items[i].Picture.Width)) &&
                     (this.PositionY + 16 >= items[i].PositionY && this.PositionY + 16 <= (items[i].PositionY + items[i].Picture.Height))))
                {
                    Health.HelthCount += items[i].BonusHealth;
                    Life.LifeCount += items[i].BonusLife;
                    Score.ScoreCount += items[i].BonusScore;
                    items[i].Picture.Visible = false;
                    items.RemoveAt(i);
                }
            }

            return items;
        }

        public bool CheckForExit(PictureBox door)
        {
            if (((this.PositionX + 16 >= door.Location.X && this.PositionX + 16 <= (door.Location.X + door.Width)) &&
                 (this.PositionY + 16 >= door.Location.Y && this.PositionY + 16 <= (door.Location.Y + door.Height))))
            {
                return true;
            }

            return false;
        }
    }
}
