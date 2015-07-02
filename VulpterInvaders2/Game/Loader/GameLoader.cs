namespace Game.Loader
{
    using System.Windows.Forms;

    public class GameLoader
    {
        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenuUI());
            Application.Exit();
        }
    }
}
