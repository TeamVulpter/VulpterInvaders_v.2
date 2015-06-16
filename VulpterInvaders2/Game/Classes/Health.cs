using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
