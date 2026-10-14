using System;
using NUnit.Framework;

namespace BuildResultAnalysisTest;

public class Tests
{
    [Test]
    public void FailsOnFirstAttemptAndPassesOnRetry()
    {
        var attempt = Environment.GetEnvironmentVariable("SCENARIO_TEST_ATTEMPT");
        if (attempt is null)
        {
            Assert.Pass("The companion pipeline does not participate in the retry scenario.");
        }
        else
        {
            Assert.That(int.TryParse(attempt, out int attemptNumber), Is.True, "Expected a numeric job attempt.");
            Assert.That(attemptNumber, Is.GreaterThan(1), "Intentional failure on the first build attempt.");
        }
    }
}