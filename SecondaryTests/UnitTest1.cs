using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace SecondaryTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task LongFailingTestAsync()
        {
            await Task.Delay(TimeSpan.FromMinutes(5));
            Assert.Fail();
        }
    }
}