using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(1,2,3,6)]
        [InlineData(2,4,6,12)]
        [InlineData(5,10,15,30)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calculator = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calculator.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
            
        }

        [Theory]
        [InlineData(6,3,3)]
        [InlineData(12,2,10)]
        [InlineData(55,5,50)]
        [InlineData(27,7,20)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var tester = new Calculator();
            //Act
            var actual = tester.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(5,5,25)]
        [InlineData(10,10,100)]
        [InlineData(4,4,16)]
        [InlineData(2,2,4)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:
            
            //Arrange
            var multiply = new Calculator();
            //Act
            var actual = multiply.Multiply( num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,2,5)]
        [InlineData(25,5,5)]
        [InlineData(9,3,3)]
        [InlineData(6,2,3)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var divide = new Calculator();
            //Act
            var actual = divide.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
