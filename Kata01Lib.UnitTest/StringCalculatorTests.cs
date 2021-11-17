using System;
using Xunit;

namespace Kata01Lib.UnitTest
{
    public class StringCalculatorTests
    {
        [Fact]
        public void Add_EmptyString_ReturnsZero()
        {
            // Arrange
            var sut = new StringCalculator();

            // Act
            var actualResult = sut.Add("");

            // Assert
            Assert.Equal(0, actualResult);
        }

        [Fact]
        public void Add_1_Returns1()
        {
            // Arrange
            var sut = new StringCalculator();

            // Act
            var actualResult = sut.Add("1");

            // Assert
            Assert.Equal(1, actualResult);
        }

        [Theory]
        [InlineData("2", 2)]
        [InlineData("3", 3)]
        [InlineData("4", 4)]
        public void Add_SingleNumber_ReturnsSuppliedNumber(string input, int expectedResult)
        {
            // Arrange
            var sut = new StringCalculator();

            // Act
            var actualResult = sut.Add(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Add_1Comma2_Returns3()
        {
            // Arrange
            var sut = new StringCalculator();

            // Act
            var actualResult = sut.Add("1,2");

            // Assert
            Assert.Equal(3, actualResult);
        }

        [Theory]
        [InlineData("2,2", 4)]
        [InlineData("2,3", 5)]
        [InlineData("2,4", 6)]
        public void Add_TwoNumbers_ReturnsSuppliedNumber(string input, int expectedResult)
        {
            // Arrange
            var sut = new StringCalculator();

            // Act
            var actualResult = sut.Add(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Add_1Comma2Comma3_ThrowsArgumentException()
        {
            // Arrange
            var sut = new StringCalculator();

            // Act
            Action action = () => sut.Add("1,2,3");

            // Assert
            var exception = Assert.Throws<ArgumentException>(action);
            Assert.Equal("numbers", exception.ParamName);
            Assert.StartsWith("Supplied too many numbers : 3", exception.Message);
        }
    }
}
