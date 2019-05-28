using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(15, "FizzBuzz")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(1, "1")]
        public void GetOutput_InputIsDevisibleBy3Or5_ReturnFizzBuzz(int testValue, string expectedResult)
        {
            var result = FizzBuzz.GetOutput(testValue);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        // do this tests by testcases
        //[Test]
        //public void GetOutput_InputIsDevisibleBy3Only_ReturnFizz()
        //{
        //    int testValue = 3;
        //    var result = FizzBuzz.GetOutput(testValue);
        //    Assert.That(result, Is.EqualTo("Fizz"));
        //}

        //[Test]
        //public void GetOutput_InputIsDevisibleBy5Only_ReturnBuzz()
        //{
        //    int testValue = 5;
        //    var result = FizzBuzz.GetOutput(testValue);
        //    Assert.That(result, Is.EqualTo("Buzz"));
        //}

        //[Test]
        //public void GetOutput_InputIsNotDevisibleBy3Or5_ReturnTheSameNumberAsString()
        //{
        //    int testValue = 1;
        //    var result = FizzBuzz.GetOutput(testValue);
        //    Assert.That(result, Is.EqualTo(testValue.ToString()));
        //}
    }
}
