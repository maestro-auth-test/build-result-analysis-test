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
            Assert.True(false);
            
        }

        [Fact]
        public void AlwaysPassing()
        {
            Assert.True(false);
        }
    }
}