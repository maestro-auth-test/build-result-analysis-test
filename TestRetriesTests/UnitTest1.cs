using System;
using System.IO;
using Xunit;

namespace TestRetriesTests
{
    public class UnitTest1
    {
        [Fact]
        public void Attempt1FailOnceThenPass()
        {
            var target = Path.Combine(Environment.GetEnvironmentVariable("HELIX_WORKITEM_ROOT"), "myresult123456", "my-result-123456.txt");
            var result = false;

            var lines = File.ReadAllLines(target);

            foreach (var line in lines)
                if (line.Contains("True"))
                    result = true;

            Assert.True(result);
        }


        [Fact]
        public void FailOnceThenPass()
        {
            var target = Path.Combine(Environment.GetEnvironmentVariable("HELIX_WORKITEM_ROOT"), "my-result-123456.txt");
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

