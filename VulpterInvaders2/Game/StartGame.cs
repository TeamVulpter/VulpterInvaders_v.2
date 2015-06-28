namespace Game
{
    using System;
    using Engine;

    public static class StartGame
    {
        [STAThread]
        public static void Main()
        {
            GameEngineVulpterInvaders engineVulpter = new GameEngineVulpterInvaders();
            engineVulpter.Run();
        }
    }
}
