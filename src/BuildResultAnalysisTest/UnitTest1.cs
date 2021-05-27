using System;
using NUnit.Framework;

namespace BuildResultAnalysisTest
{
    public class Tests
    {
        [Test]
        public void TestFailingRandomly()
        {
            Random rand = new Random();
            bool result = rand.Next(0, 2) != 0;
           
                Assert.Fail();
           
        }

    }
}