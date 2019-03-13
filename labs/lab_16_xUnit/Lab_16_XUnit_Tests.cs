using System;
using Xunit;
using lab_16_NUnit_XUNIT_Tests;

namespace lab_16_xUnit
{
    public class Lab_16_XUnit_Tests
    {
        [Fact]
        public void Lab_16_Math_Power()
        {
            // arrange
            var expected = 36.0;
            var instance03 = new TestMeNow();
            // act
            var actual = instance03.TestThisMethodWokrs(2, 3, 2);
            // assert
            Assert.Equal(expected, actual);
        }
    }
}
