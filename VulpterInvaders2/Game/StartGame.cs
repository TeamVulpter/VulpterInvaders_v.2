namespace Game
{
    using System;
    using Loader;

    public static class StartGame
    {
        [STAThread]
        public static void Main()
        {
            GameLoader engineVulpter = new GameLoader();
            engineVulpter.Run();
        }
    }
}
