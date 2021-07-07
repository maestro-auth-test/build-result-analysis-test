using NUnit.Framework;

namespace BuildResultAnalysisTest
{
    public class Tests
    {
        [TestCase("Ali")]
        [TestCase("Ali02")]
        public void TestAlwaysFailing(string scenario)
        {
            Assert.Fail();
        }

    }
}