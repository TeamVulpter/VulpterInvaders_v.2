using Game.Interfaces;

namespace Game.Classes.Bricks
{
    using System.Windows.Forms;

    class ObsticleBrick : GameObject, IMovable
    {
        public ObsticleBrick(PictureBox obsticleBox)
            : base(obsticleBox.Location.X, obsticleBox.Location.Y)
        {
            this.ObsticleBox = obsticleBox;
        }

        public PictureBox ObsticleBox { get; set; }

        public void MoveLeft()
        {
            this.ObsticleBox.Left -= 1;
        }

        public void MoveRight()
        {
            this.ObsticleBox.Left += 1;
        }
    }
}
