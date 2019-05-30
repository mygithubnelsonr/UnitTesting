using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Fundamentals
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        private ErrorLogger logger;

        [SetUp]
        public void SetUp()
        {
            logger = new ErrorLogger();
        }

        [Test]
        public void ErrorLogger_Log_WhenCalled_SetTheLastErrorProperty()
        {
            logger.Log("abc");
            Assert.That(logger.LastError, Is.EqualTo("abc"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void ErrorLogger_Log_InvalideError_ThrowArgumentNullExeption(string error)
        {
            // logger.Log(error); will throw an exeption and the test will fail

            // deligate using a lambda expression
            //Assert.That(() => logger.Log(error), Throws.Exception.TypeOf<ArgumentNullException>());
            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);

        }

        // testing a method that raises an error
        [Test]
        public void ErrorLogger_Log_ValidError_RaiseErrorloggedEvent()
        {
            var id = Guid.Empty;

            // subscribe to that event the test method
            logger.ErrorLogged += (sender, args) => { id = args; };
            logger.Log("a");
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }

        // do not test private or protected methods
        //[Test]
        //public void OnErrorLogged_WhenCalled_RaiseEvent()
        //{
        //    logger.OnErrorLogged();
        //    Assert.That(true);
        //}
    }
}
