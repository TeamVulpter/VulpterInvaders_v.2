namespace Game.Interfaces
{
    using System.Collections.Generic;
    using Classes.Enemies;

    public interface IAttack
    {
        void UpdateAttack(IList<EnemyShip> enemies);
    }
}
