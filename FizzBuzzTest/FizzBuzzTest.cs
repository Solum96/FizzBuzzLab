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
            
            var res3 = p.FizzBuzz(4);
            var res4 = p.FizzBuzz(19);

            // Assert
            Assert.AreEqual("Fizz", res1);
            Assert.AreEqual("Fizz", res2);
            
            Assert.AreNotEqual("Fizz", res3);
            Assert.AreNotEqual("Fizz", res4);
        }

        [TestMethod]
        public void BuzzTest()
        {
            // Arrange
            var p = new Program();

            // Act
            var res1 = p.FizzBuzz(5);
            var res2 = p.FizzBuzz(25);
            
            var res3 = p.FizzBuzz(6);
            var res4 = p.FizzBuzz(26);

            // Assert
            Assert.AreEqual("Buzz", res1);
            Assert.AreEqual("Buzz", res2);
            
            Assert.AreNotEqual("Buzz", res3);
            Assert.AreNotEqual("Buzz", res4);
        }

        [TestMethod]
        public void FizzBuzzTest()
        {
            // Arrange
            var p = new Program();

            // Act
            var res1 = p.FizzBuzz(15);
            var res2 = p.FizzBuzz(90);

            var res3 = p.FizzBuzz(13);
            var res4 = p.FizzBuzz(91);

            // Assert
            Assert.AreEqual("FizzBuzz", res1);
            Assert.AreEqual("FizzBuzz", res2);
            
            Assert.AreNotEqual("FizzBuzz", res3);
            Assert.AreNotEqual("FizzBuzz", res4);
        }

        [TestMethod]
        public void FizzBuzz42Test()
        {
            // Arrange
            var p = new Program();

            // Act
            var res1 = p.FizzBuzz(42);
            var res2 = p.FizzBuzz(84);

            // Assert
            Assert.AreEqual("Answer to the Ultimate Question of Life, the Universe, and Everything", res1);
            Assert.AreNotEqual("Answer to the Ultimate Question of Life, the Universe, and Everything", res2);
        }
    }
}
