using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzLab;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void FizzBuzzTest()
        {
            //Arrange
            var p = new Program();

            //Act
            var res1 = p.FizzBuzz(3);
            var res2 = p.FizzBuzz(5);
            var res3 = p.FizzBuzz(15);
            var res4 = p.FizzBuzz(42);

            var res5 = p.FizzBuzz(18);
            var res6 = p.FizzBuzz(25);
            var res7 = p.FizzBuzz(90);

            //Assert
            Assert.AreEqual("Fizz", res1);
            Assert.AreEqual("Buzz", res2);
            Assert.AreEqual("FizzBuzz", res3);
            Assert.AreEqual("Answer to the Ultimate Question of Life, the Universe, and Everything", res4);

            Assert.AreEqual("Fizz", res5);
            Assert.AreEqual("Buzz", res6);
            Assert.AreEqual("FizzBuzz", res7);
        }
    }
}
