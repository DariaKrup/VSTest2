using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectWithIgnoredTests
{
    [TestClass]
    public class Class1
    {

        [TestMethod]
        public void TestNormal()
        {
            Console.WriteLine("Normal test running");
        }

        [TestMethod, Ignore]
        public void TestIgnored()
        {
            throw new Exception("WTF?");
        }

    }
}
