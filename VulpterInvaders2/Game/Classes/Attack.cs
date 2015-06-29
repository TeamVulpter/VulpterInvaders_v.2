using System.Collections.Generic;
using System.Windows.Forms;
using Game.Classes.Enemies;

namespace Game.Classes
{
    using System;
    using Interfaces;

    public class Attack : IAttack
    {
        //private IList<EnemyShip> enemies;
        public void UpdateAttack(IList<EnemyShip> enemies)
        {
            //foreach (var en in enemies)
            //{
                List<EnemyShip> newList = new List<EnemyShip>();
                for (int i = 0; i < enemies.Count; i++)
                {

                    EnemyShip oldInvader = enemies[i];
                    EnemyShip newInvader = new EnemyShip(enemies[i].EnemyInvader)
                    {
                        PositionX = oldInvader.PositionX,
                        PositionY = oldInvader.PositionY + 1
                    };
                    //newInvader.EnemyInvaderString = oldInvader.EnemyInvaderString;
                    //newInvader.Color = oldInvader.Color;

                    if (newInvader.PositionY < 400)
                    {
                        newList.Add(newInvader);
                    }
                }
                enemies = newList;
        }
        //}
    }
}
