using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DirtyCode;
namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(4, 3, 7)]
        [InlineData(21, 5.25, 26.25)]
        public void Add_ShouldAddTwoNumber(double firstNumber, double secondNumber, double expected)
        {
            // Arrange
            AddOperation add = new AddOperation();
            // Act
            double actual = add.Calculate(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,1)]
        public void Divide_ShouldDivideTwoNumbers(double firstNumber, double secondNumber, double expected)
        {
            // Arrange
            DivideOperation divide = new DivideOperation();
            // Act
            double actual = divide.Calculate(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Divide_ShouldThrowExceptionWhenDivideOnZero()
        {
            // Arrange

            DivideOperation divide = new DivideOperation();


            // Assert
            Assert.Throws<ArgumentException>("secondNumber",() => divide.Calculate(5, 0));
        }
    }
}
