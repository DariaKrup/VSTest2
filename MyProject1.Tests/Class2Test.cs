using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProject1.Tests
{
    [TestClass]
    public class Class2Test
    {

        private Class2 myClassUnderTest;

        [TestInitialize]
        public void Init()
        {
            myClassUnderTest = new Class2();
        }

        [TestMethod]
        public void TestVoid()
        {
            try
            {
                myClassUnderTest.MethodVoid();
                Assert.Fail("Should throw exception");
            }
            catch(NotImplementedException)
            {
                
            }
        }

        [TestMethod]
        public void TestInt()
        {
            try
            {
                myClassUnderTest.MethodInt();
                Assert.Fail("Should throw exception");
            }
            catch (NotImplementedException)
            {

            }            
        }

        [TestMethod]
        public void TestString()
        {
            try
            {
                myClassUnderTest.MethodString();
                Assert.Fail("Should throw exception");
            }
            catch (NotImplementedException)
            {

            }
        }

        [TestMethod]
        public void TestRunSomeLongRunningTest()
        {
            try
            {
                Thread.Sleep(15000);
            }
            catch (Exception)
            {
                Assert.Fail("Unfortunately...");
            }
        }

    }
}
