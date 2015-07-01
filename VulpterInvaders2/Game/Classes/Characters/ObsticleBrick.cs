namespace Game.Classes.Characters
{
    using System.Windows.Forms;

    class ObsticleBrick : GameObject
    {
        public ObsticleBrick(int positionX, int positionY, PictureBox obsticleBox)
            : base(positionX, positionY)
        {
            this.ObsticleBox = obsticleBox;
        }

        public PictureBox ObsticleBox { get; set; }
    }
}
