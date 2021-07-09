using System.IO;
using NUnit.Framework;

namespace BuildResultAnalysisTest
{
    public class Tests
    {
        [Test]
        public void FailOnceThenPass()
        {
           

            Assert.Pass();
        }
    }
}