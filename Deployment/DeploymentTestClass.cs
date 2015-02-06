using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deployment
{
    [TestClass]
    public class DeploymentTestClass
    {

        [TestMethod]
        public void ShouldPass()
        {
            
        }

        [TestMethod]
        public void ShoudPassWithDeployment()
        {
            var files = Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "*", SearchOption.TopDirectoryOnly).Select(Path.GetFileName);
            if (!files.Contains("myRequiredFile.txt"))
            {
                Assert.Fail("myRequiredFile.txt was not found");
            }
        }
    }
}
