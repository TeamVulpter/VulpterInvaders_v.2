using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
