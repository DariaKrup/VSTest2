using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FailedTests
{
    [TestClass]
    public class FailedTestsContainer
    {
        [TestMethod]
        [TestCategory("failed")]
        public void A()
        {
            Assert.Fail("Failed as expected");
        }
        
        [TestMethod]
        [TestCategory("failed")]
        public void AB()
        {
            Assert.Fail("Failed as expected too");
        }


        [TestMethod]
        [TestCategory("failed")]
        public void ABC()
        {
            throw new Exception("Failed due to exception");
        }

    }
}
