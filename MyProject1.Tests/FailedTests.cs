using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProject1.Tests
{
    [TestClass]
    public class FailedTests
    {
        [TestMethod]
        [TestCategory("Failed")]
        public void TestFailedAssert()
        {
            Assert.Fail("Test fail due to assertion");
        }

        [TestMethod]
        [TestCategory("Failed")]
        public void TestFailedException()
        {
            throw new Exception("Test failed due to exception");
        }

        [TestMethod]
        [TestCategory("Failed")]
        public void TestFailedLongRunning()
        {
            Thread.Sleep(20000);
            throw new Exception("Long-running test failed. What a tragedy...");
        }
    }
}
