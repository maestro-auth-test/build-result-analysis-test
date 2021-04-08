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
            if (result)
            {
                Assert.Fail();
            }
            else
            {
                Assert.Pass();
            }
        }

        [Test]
        public void TestFailingRandomlyS2()
        {
            Random rand = new Random();
            bool result = rand.Next(0, 2) != 0;
            if (result)
            {
                Assert.Fail();
            }
            else
            {
                Assert.Pass();
            }
        }

        [Test]
        public void TestFailingRandomlyT3()
        {
            Random rand = new Random();
            bool result = rand.Next(0, 2) != 0;
            if (result)
            {
                Assert.Fail();
            }
            else
            {
                Assert.Pass();
            }
        }
    }
}