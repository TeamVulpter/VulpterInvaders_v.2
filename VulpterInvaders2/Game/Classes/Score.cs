namespace Game.Classes
{
    public class Score
    {
        static Score()
        {
            ScoreCount = 0;
        }

        public static int ScoreCount { get; set; }
    }
}
