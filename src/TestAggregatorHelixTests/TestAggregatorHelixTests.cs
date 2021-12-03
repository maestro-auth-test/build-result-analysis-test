using System;
using System.IO;
using Xunit;

namespace TestAggregatorHelixTests
{
    public class TestAggregatorHelixTests
    {
        [Fact]
        public void TestResultDeterminedByCorrelationPayload()
        {
            var result = false;
            var target = Path.Combine(Environment.GetEnvironmentVariable("HELIX_CORRELATION_PAYLOAD"),
                "my-result-123456.txt");

            var lines = File.ReadAllLines(target);

            foreach (var line in lines)
                if (line.Contains("Pass"))
                    result = true;

            Assert.True(result);
        }
    }
}

