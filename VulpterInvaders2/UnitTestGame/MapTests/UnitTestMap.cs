namespace UnitTestGame.MapTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Game.Classes.Map;

    [TestClass]
    public class UnitTestMap
    {

        private const int topDefault = 10;
        private const int leftDefault = 10;
        private const int downDefault = 510;
        private const int rightDefault = 510;

        private Map map = new Map(topDefault, leftDefault, downDefault, rightDefault);

        [TestMethod]
        public void TestMethodMapTopNotZero()
        {
            int top = this.map.Top;
            Assert.AreNotEqual(0, top);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), 
            "Value for top of field, cannot be negative!")]
        public void TestMethodMapTopCheckExceptionForNegativeValue()
        {
           this.map.Top = -1;
        }
    }
}
