using System;
using System.IO;
using System.Linq;
using Xunit;

namespace TestRetriesTests
{
    public class UnitTest1
    {
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
