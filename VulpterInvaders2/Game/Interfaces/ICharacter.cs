namespace Game.Interfaces
{
    interface ICharacter
    {
        void CreateHero(int positionX, int positionY, string heroName);
        void KillHero();

        void AddHealth(int points);
        void RemoveHealth(int points);
    }
}
