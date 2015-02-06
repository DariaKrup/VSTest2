using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MyProject1.Tests
{
    [TestClass]
    public class Class1Test
    {
        private Class1 myClassUnderTest;

        [TestInitialize]
        public void Init()
        {
            myClassUnderTest = new Class1();
        }
        
        [TestMethod]
        public void TestVoid()
        {
            myClassUnderTest.MethodVoid();
        }

        [TestMethod]
        public void TestInt()
        {
            Assert.AreEqual(0, myClassUnderTest.MethodInt());
        }

        [TestMethod]
        public void TestString()
        {
            Assert.AreEqual("This is a String!", myClassUnderTest.MethodString());
        }

        [TestMethod]
        public void TestRunSomeLongRunningTest()
        {
            try
            {
                Thread.Sleep(10000);
            }
            catch (Exception)
            {
                Assert.Fail("Unfortunately...");
            }
        }
    }
}
