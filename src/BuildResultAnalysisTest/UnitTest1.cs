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
            var all = "";
            if (exists)
            {
                all = File.ReadAllText(target);
                File.WriteAllText(target, "Test failed twice");
            }
            if (!exists)
            {
                File.WriteAllText(target, "Test failed once");
            }


            Assert.True(all.Contains("Test failed twice"));
        }
    }
}