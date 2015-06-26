namespace Game.Classes.Characters
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
