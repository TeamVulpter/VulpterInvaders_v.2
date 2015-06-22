using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.Classes.Characters
{
    class ObsticleBrick:Character
    {
        public ObsticleBrick(int positionX, int positionY,PictureBox obsticleBox) : base(positionX, positionY)
        {
            this.ObsticleBox = obsticleBox;
        }

        public PictureBox ObsticleBox { get; set; }
    }
}
