using System;
using Xunit;
using cal.Controllers;

namespace caltests
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(6, Add(3, 3));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        int Add(int x, int y) => x + y;
    }
}
