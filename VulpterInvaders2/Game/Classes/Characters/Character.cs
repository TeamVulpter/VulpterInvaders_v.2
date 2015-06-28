namespace Game.Classes.Characters
{
    using Interfaces;

    public abstract class Character : GameObject, ICharacter
    {
        protected Character(int positionX, int positionY)
            : base(positionX, positionY)
        {
        }
    }
}
