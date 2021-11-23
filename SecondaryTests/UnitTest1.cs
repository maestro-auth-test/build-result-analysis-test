using NUnit.Framework;

namespace SecondaryTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Fact]
        public void FailOnceThenPass()
        {
            Assert.True(false);
        }

        [Fact]
        public void AlwaysPassing()
        {
            Assert.True(false);
        }
    }
}