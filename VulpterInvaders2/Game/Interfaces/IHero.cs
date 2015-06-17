namespace Game.Interfaces
{
    interface ICharacter
    {
        void CreateHero(int positionX, int positionY, string heroName);
        void KillHero();

        void AddHealth(int points);
        void RemoveHealth(int points);

        void AddLives(int life);
        void RemoveLives(int life);

        void AddScores(int score);
        void RemoveScores(int score);
    }
}
