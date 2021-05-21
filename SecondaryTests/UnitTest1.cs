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
        public void FailingTest()
        {
            Assert.Fail();
        }

    }
}