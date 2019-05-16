// using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        //[TestMethod]
        // all are public void, naming convention is Method_Scenario_ExpectedBehavior()
        // the method has three parts:
        // Arrange
        // Act
        // Assert

        [Test]
        public void CanBeCanceldBy_UserIsAdmin_ReturnsTrue()
        {
            var reservation = new Reservation();
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            // with NUnit this three Assert commands are equal, it's up to you to choose one
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);   // Mosh prefere this one
            //Assert.That(result == true);

        }

        [Test]
        public void CanBeCanceldBy_SameUserCancellingTheReservation_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };
            var result = reservation.CanBeCancelledBy(user);
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCanceldBy_AnotherUserCancellingReservation_ReturnsFalse()
        {
            var reservation = new Reservation { MadeBy = new User() };
            var result = reservation.CanBeCancelledBy(new User());
            Assert.IsFalse(result);
        }
    }
}
