//this file contains health points on player and player ship
namespace Game.Classes
{
    public class Health
    {
        static Health()
        {
            HealthCount = 150;
        }

        public static int HealthCount { get; set; }
    }
}
