using NUnit.Framework;

namespace SecondaryTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Ignore("temp")]
        public void FailingTest()
        {
            Assert.Fail();
        }
    }
}