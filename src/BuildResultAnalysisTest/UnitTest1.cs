using NUnit.Framework;
using System.IO;

namespace BuildResultAnalysisTest
{
    public class Tests
    {
        [Test]
        [Ignore("temp")]
        public void TestAlwaysFailing()
        {
            Assert.Fail();
        }

        [Test]
        public void TestMethod1()
        {
            if (!File.Exists("test.txt"))
            {
                File.Create("test.txt");
                Assert.Fail("test.txt does not exist, creating");
            }
            else
            {
                File.Delete("test.txt");
                Assert.IsTrue(true, "test.txt found, deleting");
            }

        }

    }
}