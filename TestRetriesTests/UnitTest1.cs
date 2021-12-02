using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace TestRetriesTests
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public UnitTest1(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void FailOnceThenPass()
        {
            var target = Path.Combine(Environment.GetEnvironmentVariable("HELIX_CORRELATION_PAYLOAD"), "my-result-123456.txt");
            var result = false;

            var lines = File.ReadAllLines(target);

            foreach (var line in lines)
                if (line.Contains("True"))
                    result = true;

            Assert.True(result);
        }

        [Fact]
        public void AlwaysPassing()
        {
            Assert.True(true);
        }
    }
}

