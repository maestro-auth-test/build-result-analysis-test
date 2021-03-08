using NUnit.Framework;

namespace BuildResultAnalysisE2ETest
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