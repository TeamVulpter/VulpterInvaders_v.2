namespace Game.Interfaces
{
    interface IHero
    {
        void CreateHero();
        void KillHero();

        void AddHealth();
        void RemoveHealth();

        void AddLives();
        void RemoveLives();
    }
}
