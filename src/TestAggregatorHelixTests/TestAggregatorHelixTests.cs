using System;
using System.IO;
using Newtonsoft.Json.Bson;
using Xunit;

namespace TestAggregatorHelixTests
{
    public class TestAggregatorHelixTests
    {
        //This test is run twice, one with correlation payload message: 'Pass' and other with correlation payload message: 'Fail'
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

        [Fact]
        public void HelixFailingWithDifferentFailure()
        {
            var result = false;
            var target = Path.Combine(Environment.GetEnvironmentVariable("HELIX_CORRELATION_PAYLOAD"),
                "my-result-123456.txt");

            var lines = File.ReadAllLines(target);

            foreach (var line in lines)
                if (line.Contains("Pass"))
                    result = true;

            if (!result)
            {
                string test = "abcdefg";
                Assert.Contains(test, "opqrstuv");
            }

            Assert.True(result);
        }
    }
}

