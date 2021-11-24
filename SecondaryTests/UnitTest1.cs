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
            Assert.True(true);
        }

        [Fact]
        public void AlwaysPassing()
        {
            Assert.True(true);
        }
    }
}