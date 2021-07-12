using System;
using System.IO;
using System.Linq;
using Xunit;

namespace TestRetriesTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("my-test-file-123456.snt")]
        [InlineData("my-test-file-123457.snt")]
        public void FailOnceThenPass(string fileName)
        {
            var target = Path.Combine(Path.GetTempPath(), fileName);
            bool exists = File.Exists(target);
            if (!exists)
            {
                File.WriteAllText(target, "Test failed once");
            }

            Assert.True(exists);
        }
    }
}
