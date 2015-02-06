using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests32_64
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void TestFailIf32()
        {
            if (IntPtr.Size == 4)
            {
                throw new AssertFailedException("Process is not 32bit");
            }
        }
    }
}
