using System;

namespace Game.Classes.Characters
{
    public class PlayerShip : Character
    {
        public PlayerShip(int positionX, int positionY)
            : base(positionX, positionY)
        {

        }
        public override void AddHealth(int points)
        {
            throw new NotImplementedException();
        }

        public override void RemoveHealth(int points)
        {
            throw new NotImplementedException();
        }

        public override void AddLives(int life)
        {
            throw new NotImplementedException();
        }

        public override void RemoveLives(int life)
        {
            throw new NotImplementedException();
        }

        public override void AddScores(int score)
        {
            throw new NotImplementedException();
        }

        public override void RemoveScores(int score)
        {
            throw new NotImplementedException();
        }

        public override void Mooving(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
