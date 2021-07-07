using System.IO;
using NUnit.Framework;

namespace BuildResultAnalysisTest
{
    public class Tests
    {
        [Test]
        public void FailOnceThenPass()
        {
            var target = Path.Combine(Path.GetTempPath(), "my-test-file-123456.snt");
            bool exists = File.Exists(target);
            if (!exists)
            {
                File.WriteAllText(target, "Test failed once");
            }

            Assert.True(exists, $"File should exist: {target}");
        }
    }
}