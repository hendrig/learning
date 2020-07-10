using LogAn.Chapter2;
using NUnit.Framework;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidLogFileName_Bad_Extension_ReturnsFalse()
        {
            LogAnalyzer log = new LogAnalyzer();

            var result = log.IsValidLogFileName("invalid_extension.foo");

            Assert.False(result);
        }
    }
}