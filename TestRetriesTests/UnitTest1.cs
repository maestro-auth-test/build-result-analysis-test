using System;
using System.IO;
using System.Linq;
using Xunit;

namespace TestRetriesTests
{
    public class UnitTest1
    {
        [Fact]
        public void FailOnceThenPass()
        {
            var target = Path.Combine(Path.GetTempPath(), "my-test-file-123454.snt");
            bool exists = File.Exists(target);
            if (!exists)
            {
                File.WriteAllText(target, "Test failed once");
            }



            Assert.True(exists);
        }

        [Theory]
        [InlineData("my-test-file-123456.snt")]
        [InlineData("my-test-file-123457.snt")]
        public void FailOnceThenPassDataDriven(string fileName)
        {
            var target = Path.Combine(Path.GetTempPath(), fileName);
            bool exists = File.Exists(target);
            if (!exists)
            {
                File.WriteAllText(target, "Test failed once");
            }



            Assert.True(exists);
        }

        [Fact]
        public void AlwaysPassing()
        {
            Assert.True(true);
        }
    }
}
