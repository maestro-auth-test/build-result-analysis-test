using NUnit.Framework;

namespace BuildResultAnalysisTest
{
    public class Tests
    {
        [Test]
        public void TestAlwaysFailing()
        {
            // Chad's weird comment
            Assert.Fail();
        }
    }
}
