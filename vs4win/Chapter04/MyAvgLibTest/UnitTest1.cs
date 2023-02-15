using Xunit;
using MyAvgLib;

namespace MyAvgLibTest{
    public class AverageTests
    {
        [Fact]
        public void TestAverageOfTwoNumbers()
        {
            double a = 10.5;
            double b = 7.2;
            double expected = 8.85;

            double actual = Average.Avg(a, b);

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void TestAverageOfThreeNumbers()
        {
            double a = 2.1;
            double b = 4.7;
            double c = 6.3;
            double expected = 4.367;

            double actual = Average.Avg(a, b, c);

            Assert.Equal(expected, actual, 3);
        }
    } 
}