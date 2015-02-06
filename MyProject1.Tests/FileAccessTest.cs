using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProject1.Tests
{
    [TestClass]
    public class FileAccessTest
    {
        [TestMethod]
        public void TestAccessCurrentDir()
        {
            Console.WriteLine("Path.GetFullPath() = " + Path.GetFullPath("."));

            // Points to location of *.cs files
            Console.WriteLine("System.Diagnostics.StackFrame.getFileName() =" + Path.GetDirectoryName(new System.Diagnostics.StackFrame(true).GetFileName()));

            Console.WriteLine("CodeBase: " + GetType().Assembly.CodeBase);

            Console.WriteLine("Working Directory: " + Directory.GetCurrentDirectory());

            Console.WriteLine("AssemblyLocation: " +  Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase));

            Console.WriteLine("AppDomain.CurrentDomain.BaseDirectory: " + AppDomain.CurrentDomain.BaseDirectory);

            /*  OUTPUT FROM TEAMCITY
             [Test Output]
             Path.GetFullPath() = C:\dist\tc29952\buildAgent\temp\buildTmp\Oleg.Rybak_UNIT-457 2014-03-21 15_17_41\Out
             System.Diagnostics.StackFrame.getFileName() =c:\dist\tc29952\buildAgent\work\593c3309681bc247\MyProject1.Tests
             CodeBase: file:///C:/dist/tc29952/buildAgent/temp/buildTmp/Oleg.Rybak_UNIT-457 2014-03-21 15_17_41/Out/MyProject1.Tests.DLL
             Working Directory: C:\dist\tc29952\buildAgent\temp\buildTmp\Oleg.Rybak_UNIT-457 2014-03-21 15_17_41\Out
             */

            /* OUTPUT FROM RESHARPER TEST RUNNER
             Path.GetFullPath() = C:\src\DotNetSampleProject\MyProject1.Tests\bin\Debug
             System.Diagnostics.StackFrame.getFileName() =c:\src\DotNetSampleProject\MyProject1.Tests
             CodeBase: file:///C:/src/DotNetSampleProject/MyProject1.Tests/bin/Debug/MyProject1.Tests.DLL
             Working Directory: C:\src\DotNetSampleProject\MyProject1.Tests\bin\Debug             
             */

            /* OUTOUT FROM RAW MSTEST (mstest /testcontainer:MyProject1.tests/bin/Debug/MyProject1.Tests.dll )
             Path.GetFullPath() = C:\src\DotNetSampleProject\TestResults\Oleg.Rybak_UNIT-457 2014-03-21 15_26_17\Out
             System.Diagnostics.StackFrame.getFileName() =c:\src\DotNetSampleProject\MyProject1.Tests
             CodeBase: file:///C:/src/DotNetSampleProject/TestResults/Oleg.Rybak_UNIT-457 2014-03-21 15_26_17/Out/MyProject1.Tests.DLL
             Working Directory: C:\src\DotNetSampleProject\TestResults\Oleg.Rybak_UNIT-457 2014-03-21 15_26_17\Out
             */

            /* OUTPUT FROM RESHARPER WITH TEST SETTINGS
             Path.GetFullPath() = C:\src\DotNetSampleProject\TestResults\WithMyOwnSettings _2014-03-21 15_45_05_\Out
             System.Diagnostics.StackFrame.getFileName() =c:\src\DotNetSampleProject\MyProject1.Tests
             CodeBase: file:///C:/src/DotNetSampleProject/TestResults/WithMyOwnSettings _2014-03-21 15_45_05_/Out/MyProject1.Tests.DLL
             Working Directory: C:\src\DotNetSampleProject\TestResults\WithMyOwnSettings _2014-03-21 15_45_05_\Out             
             */

        }
    }
}
