namespace Game
{
    using System;
    using System.Windows.Forms;
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
