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
        }

        public static void GameExit()
        {//if lives is zero or negative - game over
            if (Life.LifeCount <= 0)
            {
                MessageBox.Show("Game over");
                Application.Exit();
            }
        }

        public static void GameLifeReduction()
        {
            if (Health.HelthCount <= 0)
            {
                Life.LifeCount -= 1;
            }
        }

        public static void GameScoreMax()
        {
            if (Score.ScoreCount >= 100)
            {
                MessageBox.Show("Game over");
                Application.Exit();
            }
        }

        public static void GameHealthMax()
        {
            if (Health.HelthCount >= 250)
            {
                Life.LifeCount += 1;
                Health.HelthCount = 150;
            }
        }

    }
}
