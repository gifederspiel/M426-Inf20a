using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Fact]
        public void Test1()
        {
            int number = 1;
            var testee = new FooBarQixDeterminer();

            var result = testee.Determine(number);

            Assert.Equal("1", result);
        }
    }
}