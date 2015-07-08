using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Classes.Factory;

namespace UnitTestGame
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Generate_Random_X_Number()
        {
            ItemsFactory itemsFactory = new ItemsFactory();
            int num = itemsFactory.GenerateRandomX(1, 10);
            Assert.AreEqual(2, num, "Ops");
        }
    }
}
