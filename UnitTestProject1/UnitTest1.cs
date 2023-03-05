using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMin()
        {
            int min;
            min = Program.Min(7, 2, 5);
            Assert.AreEqual(2, min);
        }
    }
}
