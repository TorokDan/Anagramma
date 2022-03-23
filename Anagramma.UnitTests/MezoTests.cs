using NUnit.Framework;
using Anagramma;

namespace Anagramma.UnitTests
{
    public class MezoTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ToString()
        {
            OsAnya osAnyaTeszt = new OsAnya('a');
            Gyerek gyerekTesztB = new Gyerek(osAnyaTeszt, 'b');
            Gyerek gyerekTesztC = new Gyerek(gyerekTesztB, 'c');

            string result = gyerekTesztC.ToString();

            Assert.AreEqual(result, "abc");
        }
    }
}