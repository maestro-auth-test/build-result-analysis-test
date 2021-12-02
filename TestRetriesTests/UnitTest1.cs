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
        public void Attempt1FailOnceThenPass()
        {
            var target = Path.Combine(Environment.GetEnvironmentVariable("HELIX_WORKITEM_PAYLOAD"), "myresult123456", "my-result-123456.txt");
            var result = false;

            var lines = File.ReadAllLines(target);

            foreach (var line in lines)
                if (line.Contains("True"))
                    result = true;

            Assert.True(result);
        }

        [Fact]
        public void GetFiles()
        {
            string[] fileEntries = Directory.GetFiles(Environment.GetEnvironmentVariable("HELIX_CORRELATION_PAYLOAD"));
            foreach (string fileName in fileEntries)
            {
                _testOutputHelper.WriteLine("Processed file HELIX_WORKITEM_PAYLOAD '{0}'.", fileName);
            }


            string[] fileEntriesSecond = Directory.GetFiles(Environment.GetEnvironmentVariable("HELIX_WORKITEM_ROOT"));
            foreach (string fileName in fileEntriesSecond)
            {
                _testOutputHelper.WriteLine("Processed file HELIX_WORKITEM_ROOT '{0}'.", fileName);
            }

            Assert.False(true);
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

