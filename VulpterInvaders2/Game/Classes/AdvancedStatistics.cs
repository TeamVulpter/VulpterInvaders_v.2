namespace Game.Classes
{
    using System.Windows.Forms;

    public class AdvancedStatistics
    {
        public static void GameLifeReduction()
        {
            if (Health.HealthCount <= 0)
            {
                Life.LifeCount -= 1;
            }
        }

       

        public static void GameHealthMax()
        {
            if (Health.HealthCount >= 250)
            {
                Life.LifeCount += 1;
                Health.HealthCount = 150;
            }
        }

        public static void GameHealthMin()
        {
            if (Health.HealthCount <= 0)
            {
                Life.LifeCount -= 1;
            }
        }
    }
}
