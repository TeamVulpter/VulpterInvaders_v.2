using System.Collections.Generic;
using Game.Classes.Enemies;

namespace Game.Interfaces
{
    public interface IAttack
    {
        void UpdateAttack(IList<EnemyShip> enemies);
    }
}
