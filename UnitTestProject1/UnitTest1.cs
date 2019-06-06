using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSTEPS;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = Program.GetValue(new int[] { 0, 0 }, 0, 1, new int[] { 4, 4 });
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int result = Program.GetValue(new int[] { 2, 0 }, 2, 1, new int[] { 4, 2 });
            Assert.AreEqual(6, result);
        }
    }
}
