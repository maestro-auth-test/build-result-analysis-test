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
    }
}