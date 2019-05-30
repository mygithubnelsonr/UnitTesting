using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Fundamentals
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        // SetUp
        // TearDown

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        //[Ignore("Ignored: because I want to!")]
        public void Add_WhenCalled_SummOfArguments()
        {
            //var math = new Math(); can be removed because SetUp Attribute
            int result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));

            //Assert.That(_math, Is.Not.Null);
        }

        //[Test]
        //public void Max_FirstArgumentIsGreater_RetureTheFirstArguments()
        //{
        //    //var math = new Math();
        //    int result = _math.Max(2, 1);
        //    Assert.That(result, Is.EqualTo(2));
        //}

        //[Test]
        //public void Max_SecondArgumentIsGreater_RetureTheSecondArguments()
        //{
        //    //var math = new Math();
        //    int result = _math.Max(1, 2);
        //    Assert.That(result, Is.EqualTo(2));
        //}

        //[Test]
        //public void Max_ArgumentsAreEqual_RetureTheSameArguments()
        //{
        //    //var math = new Math();
        //    int result = _math.Max(1, 1);
        //    Assert.That(result, Is.EqualTo(1));
        //}

        // using TestCase Attributes to simplefy the code
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArguments(int a, int b, int expectedResult)
        {
            int result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            // needs Linq
            var result = _math.GetOddNumbers(5);

            //Assert.That(result, Is.Not.Empty);    // is to generell
            //Assert.That(result.Count(), Is.EqualTo(3));   // a little more specific 

            //Assert.That(result, Does.Contain(1));   // more specific
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            // other Asserts
            Assert.That(result, Is.Ordered);    // test if the result is sorted by the method
            Assert.That(result, Is.Unique);     // test if the result does not contain dupplicates

        }
    }
}
