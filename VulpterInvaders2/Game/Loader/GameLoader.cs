namespace Game.Loader
{
    using System.Windows.Forms;

    using Game.Interfaces;

    public class GameLoader
    {
        private IMap map;

        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenuUI(this));
            Application.Exit();
        }

        public IMap Map
        {
            get
            {
                return this.map;
            }

            set
            {
                this.map = value;
            }
        }

        private void LoadItems()
        {
            // TODO : implement add item list
        }
    }
}
