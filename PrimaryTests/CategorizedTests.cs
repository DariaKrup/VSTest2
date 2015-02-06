using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimaryTests
{
    [TestClass]
    public class CategorizedTests
    {
        [TestMethod]
        [TestCategory("slow")]
        public void SlowTest1()
        {
        }

        [TestMethod]
        [TestCategory("slow")]
        public void SlowTest2()
        {
        }

        [TestMethod]
        [TestCategory("fast")]
        public void FastTest1()
        {
        }

        [TestMethod]
        [TestCategory("fast")]
        public void FastTest2()
        {
        }

    }
}
