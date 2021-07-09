using System.IO;
using Xunit;

namespace TestRetriesTests
{
    public class UnitTest1
    {
        [Fact]
        public void FailOnceThenPass()
        {
            var target = Path.Combine(Path.GetTempPath(), "my-test-file-123456.snt");
            bool exists = File.Exists(target);
            if (!exists)
            {
                File.WriteAllText(target, "Test failed once");
            }

            Assert.True(exists);
        }

        [Fact]
        public void FailThreeTimesThenPass()
        {
            var target = Path.Combine(Path.GetTempPath(), "my-test-file-123456.snt");
            bool exists = File.Exists(target);
            var all = "";
            if (exists)
            {
                all = File.ReadAllText(target);
                File.WriteAllText(target, "Test failed twice");
                if (all.Contains("Test failed twice"))
                {
                    File.WriteAllText(target, "Test failed three times");
                }

            }
            if (!exists)
            {
                File.WriteAllText(target, "Test failed once");
            }

            Assert.Contains("Test failed three times", all);
        }
    }
}
