using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.Classes
{
    public abstract class Bullet : GameObject
    {
        protected Bullet(int positionX, int positionY, Panel bullet)
            : base(positionX, positionY)
        {

        }
        public bool IsActive { get; set; }
        public abstract void Start();
        public abstract void Stop();

    }
}
