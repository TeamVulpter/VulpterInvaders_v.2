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
