using Microsoft.VisualStudio.TestPlatform.TestHost;
using Paskaita_7;

namespace Paskaita_7_UnitTests
{
    public class Tests
    {

        [Test]
        public void Sum_ReturnsSum()
        {
            //arrange

            int number = 4;
            int number2 = 6;

            //act

            int answer = MyClass.Sum(number, number2);

            Assert.AreEqual(10,answer);
        }

        [Test]
        public void MultiplyAndAddOne_DoesNotAddOne_ReturnsMultiplied()
        {
            //arrange

            int number = 3;
            int number2 = 7;

            //act
            int answer = MyClass.MultiplyAndAddOne(number, number2);

            //assert 

            Assert.AreEqual(21,answer);
        }

        [Test]
        public void MultiplyAndAddOne_AddOne_ReturnsMultiplied()
        {
            //arrange

            int number = 3;
            int number2 = 7;

            //act
            int answer = MyClass.MultiplyAndAddOne(number, number2, true);

            //assert 

            Assert.AreEqual(22, answer);

        }

        [Test]
        public void MultiplyAndAddOne_WithAddOneTrue_ReturnsCorrectResult()
        {
            // Arrange
            int num1 = 3;
            int num2 = 4;
            bool addOne = true;

            // Act
            int result = MyClass.MultiplyAndAddOne(num1, num2, addOne);

            // Assert
            Assert.AreEqual(13, result); // 3 * 4 + 1 = 13
        }

        [Test]
        public void MultiplyAndAddOne_WithAddOneFalse_ReturnsCorrectResult()
        {
            // Arrange
            int num1 = 3;
            int num2 = 4;
            bool addOne = false;

            // Act
            int result = MyClass.MultiplyAndAddOne(num1, num2, addOne);

            // Assert
            Assert.AreEqual(12, result); // 3 * 4 = 12
        }

        [Test]
        public void MultiplyAndAddOne_WithDefaultParameter_ReturnsCorrectResult()
        {
            // Arrange
            int num1 = 5;
            int num2 = 6;

            // Act
            int result = MyClass.MultiplyAndAddOne(num1, num2);

            // Assert
            Assert.AreEqual(30, result); // 5 * 6 = 30 (addOne default is false)
        }

        [Test]
        public void MultiplyAndAddOne_WithNegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int num1 = -2;
            int num2 = -3;
            bool addOne = true;

            // Act
            int result = MyClass.MultiplyAndAddOne(num1, num2, addOne);

            // Assert
            Assert.AreEqual(7, result); // -2 * -3 + 1 = 7
        }

        [Test]
        public void MultiplyAndAddOne_WithZero_ReturnsCorrectResult()
        {
            // Arrange
            int num1 = 0;
            int num2 = 10;
            bool addOne = true;

            // Act
            int result = MyClass.MultiplyAndAddOne(num1, num2, addOne);

            // Assert
            Assert.AreEqual(1, result); // 0 * 10 + 1 = 1
        }
    }
}