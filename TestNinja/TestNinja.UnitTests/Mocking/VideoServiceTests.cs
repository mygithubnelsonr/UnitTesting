using Moq;
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
        //[Test]
        //public void ReadVideoTitle_EmptyFile_ReturnError()
        //{
        //    var service = new VideoService(new FakeFileReader());
        //    var result = service.ReadVideoTitle();
        //    Assert.That(result, Does.Contain("error").IgnoreCase);
        //}
        #endregion

        #region Dependency Injection via Constructor using Mock
        // use mocks only for external dependencies

        private VideoService _videoService;
        private Mock<IFileReader> _fileReader;

        [SetUp]
        public void Setup()
        {
            _fileReader = new Mock<IFileReader>();
            _videoService = new VideoService(_fileReader.Object);
        }

        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");
            var result = _videoService.ReadVideoTitle();
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
        #endregion
    }
}
