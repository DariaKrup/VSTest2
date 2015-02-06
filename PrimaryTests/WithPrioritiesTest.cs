
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimaryTests
{
    [TestClass]
    public class WithPrioritiesTest
    {
        [TestMethod, Priority(1)]
        public void Priority1Test1()
        {
        }

        [TestMethod, Priority(1)]
        public void Priority1Test2()
        {
        }

        [TestMethod, Priority(2)]
        public void Priority2Test1()
        {
        }

        [TestMethod, Priority(2)]
        public void Priority2Test2()
        {
        }
    }
}
