namespace Game.Classes.Characters
{
    using Interfaces;
    public abstract class Character : GameObject, ICharacter
    {
        private string name;
        private int health;
        private int lives;
        private int scores;

        protected Character(int positionX, int positionY)
            : base(positionX, positionY)
        {
        }
    }
}
