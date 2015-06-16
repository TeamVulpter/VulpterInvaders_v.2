namespace Game.Interfaces
{
    interface ICharacter
    {
        void CreateHero();
        void KillHero();

        void AddHealth();
        void RemoveHealth();

        void AddLives();
        void RemoveLives();

        void AddScores();
        void RemoveScores();
    }
}
