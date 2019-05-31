using TestNinja.Mocking;

// the FileReader Class is not longer needed if Nuget Package Moq is installed
// changed the namespace instade to delete this class
namespace TestNinja.UnitTests.NotLongerNeeded
{
    public class FakeFileReader : IFileReader
    {
        public string Read(string path)
        {
            return "";
        }
    }
}
