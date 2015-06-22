using System;
using System.Windows.Forms;

namespace Game
{
    static class StartGame
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenuUI());
            Application.Exit();
        }
    }
}
