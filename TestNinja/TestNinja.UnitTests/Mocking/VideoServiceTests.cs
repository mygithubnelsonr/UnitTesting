using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        #region Dependency Injection via Method Parameter
        //[Test]
        //public void ReadVideoTitle_EmptyFile_ReturnError()
        //{
        //    var service = new VideoService();
        //    var result = service.ReadVideoTitle(new FakeFileReader());
        //    Assert.That(result, Does.Contain("error").IgnoreCase);
        //}
        #endregion

        #region Dependency Injection via Properties
        //[Test]
        //public void ReadVideoTitle_EmptyFile_ReturnError()
        //{
        //    var service = new VideoService();
        //    service.FileReader = new FakeFileReader();
        //    var result = service.ReadVideoTitle();
        //    Assert.That(result, Does.Contain("error").IgnoreCase);
        //}
        #endregion

        #region Dependency Injection via Constructor
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            var service = new VideoService(new FakeFileReader());
            var result = service.ReadVideoTitle();
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
        #endregion
    }
}
