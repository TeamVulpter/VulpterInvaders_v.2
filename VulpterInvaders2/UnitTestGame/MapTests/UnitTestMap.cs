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

        private Map mapGlobal = new Map(topDefault, leftDefault, downDefault, rightDefault);

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

        //Within the field start
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "Value for top of field, cannot be negative!")]
        public void TestMapTopExceptionForNegativeValue()
        {
            Map map = new Map(topDefault, leftDefault, downDefault, rightDefault);
            map.Top = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "Value for top of field, cannot be negative!")]
        public void TestMapLeftExceptionForNegativeValue()
        {
            Map map = new Map(topDefault, leftDefault, downDefault, rightDefault);
            map.Left = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "The amount of the upper limit can not be greater than the standard")]
        public void TestMapDownExceptionForGreaterValue()
        {
            Map map = new Map(topDefault, leftDefault, downDefault, rightDefault);
            map.Down += 1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "The amount of the upper limit can not be greater than the standard")]
        public void TestMapRightExceptionForGreaterValue()
        {
            Map map = new Map(topDefault, leftDefault, downDefault, rightDefault);
            map.Right += 1;
        }
        //Within the field end

    }

}
