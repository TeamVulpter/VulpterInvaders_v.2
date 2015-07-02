namespace Game.Classes.Bricks
{
    using System.Windows.Forms;

    class ObsticleBrick : GameObject
    {
        public ObsticleBrick(PictureBox obsticleBox)
            : base(obsticleBox.Location.X, obsticleBox.Location.Y)
        {
            this.ObsticleBox = obsticleBox;
        }

        public PictureBox ObsticleBox { get; set; }
    }
}
