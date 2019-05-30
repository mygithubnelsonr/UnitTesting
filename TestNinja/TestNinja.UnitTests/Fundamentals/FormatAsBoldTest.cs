using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Fundamentals
{
    [TestFixture]
    public class FormatAsBoldTest
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var htmlFormatter = new HtmlFormatter();
            var testString = "abc";

            var result = htmlFormatter.FormatAsBold(testString);
            // var check = result.Replace("{contend}", testString);

            // Specific
            Assert.That(result, Is.EqualTo("<strong>ABC</strong>").IgnoreCase);

            // More generell
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));
        }

    }
}
