using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.Classes
{
    public class AdvancedStatistics
    {
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
