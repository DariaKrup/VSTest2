using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FailedTests
{
    [TestClass]
    public class FailedTestsContainer
    {
        [TestMethod]
        [TestCategory("failed")]
        public void With_Underscore()
        {
            Assert.Fail("Failed as expected");
        }
        
        [TestMethod]
        [TestCategory("failed")]
        public void Always()
        {
            Assert.Fail("Failed as expected");
        }

        [TestMethod]
        [TestCategory("failed")]
        public void With.Dot()
        {
            throw new Exception("Failed due to exception");
        }

    }
}
