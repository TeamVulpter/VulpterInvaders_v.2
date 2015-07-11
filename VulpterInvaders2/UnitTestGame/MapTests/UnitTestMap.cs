namespace UnitTestGame.MapTests
{
    using System;

    using Game.Classes.Map;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTestMap
    {
        // This is default coordinates to size of field
        private const int TopDefault = 55;
        private const int LeftDefault = 606;
        private const int DownDefault = 82;
        private const int RightDefault = 671;

        private readonly Map mapGlobal = new Map(TopDefault, LeftDefault, DownDefault, RightDefault);

        [TestMethod]
        public void TestMapTopNotZero()
        {
            Assert.AreNotEqual(0, this.mapGlobal.Top);
        }

        [TestMethod]
        public void TestMapLeftNotZero()
        {
            Assert.AreNotEqual(0, this.mapGlobal.Left);
        }

        [TestMethod]
        public void TestMapDownNotZero()
        {
            Assert.AreNotEqual(0, this.mapGlobal.Down);
        }

        [TestMethod]
        public void TestMapRightNotZero()
        {
            Assert.AreNotEqual(0, this.mapGlobal.Right);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "Value for top of field, cannot be negative!")]
        public void TestMapTopExceptionForNegativeValue()
        {
            Map map = new Map(TopDefault, LeftDefault, DownDefault, RightDefault);
            map.Top = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "Value for Left of field, cannot be negative!")]
        public void TestMapLeftExceptionForNegativeValue()
        {
            Map map = new Map(TopDefault, LeftDefault, DownDefault, RightDefault);
            map.Left = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "Value for Down of field, cannot be negative!")]
        public void TestMapDownExceptionForGreaterValue()
        {
            Map map = new Map(TopDefault, LeftDefault, DownDefault, RightDefault);
            map.Down = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "Value for Right of field, cannot be negative!")]
        public void TestMapRightExceptionForGreaterValue()
        {
            Map map = new Map(TopDefault, LeftDefault, DownDefault, RightDefault);
            map.Right = -1;
        }
    }
}
