using AffineCipher;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AffineCipherTests
{
    [TestClass()]
    public class ShiftCipherAlgorithmTests
    {
        [TestMethod()]
        public void ConvertCharToAsciiTest()
        {
            int expected = 0;
            char letter = 'A';
            int got = ShiftCipherAlgorithm.ConvertCharToAscii(letter);
            Assert.AreEqual(expected, got);

            expected = 25;
            letter = 'Z';
            got = ShiftCipherAlgorithm.ConvertCharToAscii(letter);
            Assert.AreEqual(expected, got);

            expected = 0;
            letter = 'a';
            got = ShiftCipherAlgorithm.ConvertCharToAscii(letter);
            Assert.AreEqual(expected, got);

            expected = 25;
            letter = 'z';
            got = ShiftCipherAlgorithm.ConvertCharToAscii(letter);
            Assert.AreEqual(expected, got);

            expected = 26;
            letter = ' ';
            got = ShiftCipherAlgorithm.ConvertCharToAscii(letter);
            Assert.AreEqual(expected, got);
        }
    }
}

namespace AffineCipherTest
{
    [TestClass()]
    public class ShiftCipherAlgorithmTests
    {
        [TestMethod()]
        public void ConvertToAsciiTest()
        {

            
        }
    }
}