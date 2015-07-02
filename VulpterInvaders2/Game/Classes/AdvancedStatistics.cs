namespace Game.Classes
{
    using System.Windows.Forms;

    public class AdvancedStatistics
    {
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
