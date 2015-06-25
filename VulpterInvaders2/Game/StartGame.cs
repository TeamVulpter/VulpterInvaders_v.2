namespace Game
{
    using System;
    using Engine;

    static class StartGame
    {
        [STAThread]
        static void Main()
        {
            GameEngineVulpterInvaders engineVulpter = new GameEngineVulpterInvaders();
            engineVulpter.Run();
        }
    }
}
