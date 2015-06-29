//this file contains health points on player and player ship
namespace Game.Classes
{
    public class Health
    {
        static Health()
        {
            HelthCount = 150;
        }

        public static int HelthCount { get; set; }
    }
}
