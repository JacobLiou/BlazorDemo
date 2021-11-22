using System;
using Xunit;
using Shouldly;

namespace usingShouldly
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int z = Add(1, 3);
            z.ShouldBe(3);
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
