using System;
using System.IO;
using System.Linq;
using Xunit;

namespace TestAggregatorHelixTests;

public class TestAggregatorHelixTests
{
    // This test is run several times
    // Based on the conent in the correlation payload file, it behaves differently, simulating different test results (pass, fail, known issue)
    [Fact]
    public void TestResultDeterminedByCorrelationPayload()
    {
        var target = Path.Combine(
            Environment.GetEnvironmentVariable("HELIX_CORRELATION_PAYLOAD"),
            "my-result-123456.txt");

        var lines = File.ReadAllLines(target);

        if (lines.Any(l => l.Contains("KnownIssue")))
        {
            Assert.True(false, "This failure will be matched from a known issue");
        }

        if (lines.Any(l => l.Contains("Fail")))
        {
            Assert.True(false);
        }
    }
}

