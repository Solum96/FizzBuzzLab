using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzLab;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void FizzTest()
        {
            // Arrange
            var p = new Program();

            // Act
            var res1 = p.FizzBuzz(3);
            var res2 = p.FizzBuzz(18);

            // Assert
            Assert.AreEqual("Fizz", res1);
            Assert.AreEqual("Fizz", res2);
        }

        [TestMethod]
        public void BuzzTest()
        {
            // Arrange
            var p = new Program();

            // Act
            var res1 = p.FizzBuzz(5);
            var res2 = p.FizzBuzz(25);

            // Assert
            Assert.AreEqual("Buzz", res1);
            Assert.AreEqual("Buzz", res2);
        }

        [TestMethod]
        public void FizzBuzzTest()
        {
            // Arrange
            var p = new Program();

            // Act
            var res1 = p.FizzBuzz(15);
            var res2 = p.FizzBuzz(90);

            // Assert
            Assert.AreEqual("FizzBuzz", res1);
            Assert.AreEqual("FizzBuzz", res2);
        }

        [TestMethod]
        public void FizzBuzz42Test()
        {
            // Arrange
            var p = new Program();

            // Act
            var res4 = p.FizzBuzz(42);

            // Assert
            Assert.AreEqual("Answer to the Ultimate Question of Life, the Universe, and Everything", res4);
        }
    }
}
