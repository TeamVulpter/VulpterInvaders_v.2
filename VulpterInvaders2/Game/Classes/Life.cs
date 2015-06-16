using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    public class Life
    {
        static Life()
        {
            LifeCount = 3;
        }

        public static int LifeCount { get; set; }
    }
}
