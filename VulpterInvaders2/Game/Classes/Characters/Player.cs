using System.Drawing;

namespace Game.Classes.Characters
{
    using System.Collections.Generic;
    using System.Windows.Forms;

    using Items;

    public class Player : Character
    {
        private PictureBox hero;

        public Player(PictureBox hero)
            : base(hero.Location.X, hero.Location.Y)
        {
            this.Hero = hero;
        }

        public PictureBox Hero { get; set; }
     
   


        public IList<Item> GetItem(IList<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (((this.Hero.Location.X + 16 >= items[i].PositionX && this.Hero.Location.X+16 <= (items[i].PositionX + items[i].Picture.Width)) &&
                     (this.Hero.Location.Y + 16 >= items[i].PositionY && this.Hero.Location.Y + 16 <= (items[i].PositionY + items[i].Picture.Height))))
                {
                    Health.HelthCount += items[i].BonusHealth;
                    Life.LifeCount += items[i].BonusLife;
                    Score.ScoreCount += items[i].BonusScore;
                    //remove life
                    Life.LifeCount += items[i].RemoveBonus;

                    items[i].Picture.Visible = false;
                    items.RemoveAt(i);
                }
            }

            return items;
        }

        public bool CheckForExit(PictureBox door)
        {
            if (((this.Hero.Location.X + 16 >= door.Location.X && this.Hero.Location.X + 16 <= (door.Location.X + door.Width)) &&
                 (this.Hero.Location.Y + 16 >= door.Location.Y && this.Hero.Location.Y + 16 <= (door.Location.Y + door.Height))))
            {
                return true;
            }

            return false;
        }

        public override void MoveLeft()
        {
            Hero.Location = new Point(Hero.Location.X - 5, Hero.Location.Y);
        }

        public override void MoveRight()
        {
            Hero.Location = new Point(Hero.Location.X + 5, Hero.Location.Y);
        }

        public void MoveUp()
        {
            Hero.Location = new Point(Hero.Location.X, Hero.Location.Y-5);
        }

        public void MoveDown()
        {
            Hero.Location = new Point(Hero.Location.X, Hero.Location.Y + 5);
        }

        public override bool StopAtMax(int positionOfPlayer, int maxValue)
        {
            if (positionOfPlayer > maxValue)
            {
                return true;
            }
            return false;
        }

        public override bool StopAtMin(int positionOfPlayer, int minValue)
        {
            if (positionOfPlayer < minValue)
            {
                return true;
            }
            return false;
        }
    }
}
