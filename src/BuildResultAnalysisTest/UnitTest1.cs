using NUnit.Framework;

namespace BuildResultAnalysisTest
{
    public class Tests
    {
        [Test]
        public void TestAlwaysFailing()
        {
            Assert.Fail();
        }

        [Test]
        public void TestWithDifferentNameButAlwaysFailing()
        {
            Assert.Fail();
        }

    }
}