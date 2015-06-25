namespace Game.Engine
{
    using System;
    using System.Windows.Forms;
    using Classes;

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
