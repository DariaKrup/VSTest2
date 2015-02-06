using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FailedTests
{
    [TestClass]
    public class FailedTestsContainer
    {
        [TestMethod]
        [TestCategory("failed")]
        public void ShouldFail()
        {
            Assert.Fail("Failed as expected");
        }

        [TestMethod]
        [TestCategory("failed")]
        public void ShouldFailException()
        {
            throw new Exception("Failed due to exception");
        }

    }
}
