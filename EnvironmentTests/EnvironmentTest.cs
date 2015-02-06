using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnvironmentTests
{
    [TestClass]
    public class EnvironmentTest
    {

        [TestMethod]
        public void TestIs32Bit()
        {
            Assert.IsTrue(IntPtr.Size == 4, "Runtime is not 32 bit!");
        }

        [TestMethod]
        public void TestIs64Bit()
        {
            Assert.IsTrue(IntPtr.Size == 8, "Runtime is not 64 bit!");
        }
    }
}
