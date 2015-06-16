using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.Classes.Matrix
{
    public class Brick
    {
        private PictureBox brickSingle;
        private int x;
        private int y;
    
        public Brick(PictureBox brickSingle)
        {
            this.BrickSingle = brickSingle;
           
        }

       

        public int X { get; set; }
        public int Y { get; set; }
        public PictureBox BrickSingle { get; set; }
    }
}
