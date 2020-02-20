using System;
using Xunit;
using PrimeNumbersList;

namespace PrimeNumbers_UnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,2)]
        [InlineData(2,3)]
        [InlineData(3, 5)]
        [InlineData(4, 7)]
        [InlineData(5, 11)]
        [InlineData(550, 3989)]
        [InlineData(10000, 104729)]





        public void Test1(int a, int expected)
        {
            PrimeNumbers p_getter = new PrimeNumbers();
            int result = p_getter.GetDemPriiiimes(a);
            Assert.Equal(expected, result);              
        }
    }
}
