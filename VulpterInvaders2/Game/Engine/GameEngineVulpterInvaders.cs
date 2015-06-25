using System;
using System.Windows.Forms;
using Game.Classes;

namespace Game.Engine
{
    public class GameEngineVulpterInvaders
    {

        public void Run()
        {
            while (true)
            {
                if (Score.ScoreCount>=100 || Life.LifeCount<=0)
                {
                    Application.Exit();
                }
            }
        }

        private void AddItemsToList()
        {
            
        }
    }
}
