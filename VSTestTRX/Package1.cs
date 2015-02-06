using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VSTestTRX
{
    [TestClass]
    public class Package1
    {
        [TestMethod]
        public void Test1()
        {
            Console.WriteLine("This is Test1. It should pass.");            
        }

        [TestMethod]
        public void Test2()
        {
            Console.WriteLine("This is Test2. It should fail");
            Assert.Fail("Yep, it it screwed!");
        }

        [TestMethod]
        public void TestEpicFail()
        {
            Console.WriteLine("This is Test3. It should provide epic fail");
            try
            {
                throw new Exception("Epic fail!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        [TestMethod]
        public void TestLotsOfOutputStdOut0()
        {
            for (var i = 0; i < 1000; i++)
            {
                Console.WriteLine("Output line: "  + i);
            }
        }

        [TestMethod]
        public void TestLotsOfOutputStdOut1()
        {
            for (var i = 0; i < 1000; i++)
            {
                Console.WriteLine("Output line: " + i);
            }
        }

        [TestMethod]
        public void TestLotsOfOutputStdOut2()
        {
            for (var i = 0; i < 1000; i++)
            {
                Console.WriteLine("Output line: " + i);
            }
        }

        [TestMethod]
        public void TestLotsOfOutputStdOut3()
        {
            for (var i = 0; i < 1000; i++)
            {
                Console.WriteLine("Output line: " + i);
            }
        }

        [TestMethod]
        public void TestLotsOfOutputStdOut4()
        {
            for (var i = 0; i < 1000; i++)
            {
                Console.WriteLine("Output line: " + i);
            }
        }

        [TestMethod]
        public void TestLotsOfOutputStdOut5()
        {
            for (var i = 0; i < 1000; i++)
            {
                Console.WriteLine("Output line: " + i);
            }
        }

        [TestMethod]
        public void TestLotsOfOutputStdOut6()
        {
            for (var i = 0; i < 1000; i++)
            {
                Console.WriteLine("Output line: " + i);
            }
        }

        [TestMethod]
        public void TestLotsOfOutputStdOut7()
        {
            for (var i = 0; i < 1000; i++)
            {
                Console.WriteLine("Output line: " + i);
            }
        }

        [TestMethod]
        public void TestLotsOfOutputStdOut8()
        {
            for (var i = 0; i < 1000; i++)
            {
                Console.WriteLine("Output line: " + i);
            }
        }

        [TestMethod]
        public void TestLotsOfOutputStdOut9()
        {
            for (var i = 0; i < 1000; i++)
            {
                Console.WriteLine("Output line: " + i);
            }
        }

        [TestMethod]
        public void TestLotsOfOutputStdOut10()
        {
            for (var i = 0; i < 1000; i++)
            {
                Console.WriteLine("Output line: " + i);
            }
        }

        [TestMethod]
        public void TestLotsOfOutputStdErr()
        {
            for (var i = 0; i < 1000; i++)
            {
                Console.Error.WriteLine("Output line: " + i);
            }
        }


    }
}
