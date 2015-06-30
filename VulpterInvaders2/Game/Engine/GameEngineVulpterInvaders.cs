using Game.Classes;

namespace Game.Engine
{
    using System.Windows.Forms;

    public class GameEngineVulpterInvaders
    {
        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenuUI());
            Application.Exit();
            //if lives is zero or negative - game over
            if (Life.LifeCount <= 0)
            {
                MessageBox.Show("Game over");
                Application.Exit();
            }

            //while (true)
            //{
            //    if (Score.ScoreCount>=100 || Life.LifeCount<=0)
            //    {
            //        Application.Exit();
            //    }
            //}
        }
    }
}
