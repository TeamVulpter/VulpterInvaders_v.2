namespace Game.Engine
{
    using System.Windows.Forms;

    public class GameEngineVulpterInvaders
    {
        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenuUI());
            Application.Exit();

            //while (true)
            //{
            //    if (Score.ScoreCount>=100 || Life.LifeCount<=0)
            //    {
            //        Application.Exit();
            //    }
            //}
        }
    }
}
