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

        [TestMethod]
        public void TestMethodMapTopNotZero()
        {
            Map map = new Map(topDefault, leftDefault, downDefault, rightDefault);
            int top = map.Top;
            Assert.AreNotEqual(0, top);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "Value for top of field, cannot be negative!")]
        public void TestMethodMapTopExceptionForNegativeValue()
        {
            Map map = new Map(topDefault, leftDefault, downDefault, rightDefault);
            map.Top = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "Value for top of field, cannot be negative!")]
        public void TestMethodMapLeftExceptionForNegativeValue()
        {
            Map map = new Map(topDefault, leftDefault, downDefault, rightDefault);
            map.Left = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "The amount of the upper limit can not be greater than the standard")]
        public void TestMethodMapDownExceptionForGreaterValue()
        {
            Map map = new Map(topDefault, leftDefault, downDefault, rightDefault);
            map.Down += 1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "The amount of the upper limit can not be greater than the standard")]
        public void TestMethodMapRightExceptionForGreaterValue()
        {
            Map map = new Map(topDefault, leftDefault, downDefault, rightDefault);
            map.Right += 1;
        }


    }
}
