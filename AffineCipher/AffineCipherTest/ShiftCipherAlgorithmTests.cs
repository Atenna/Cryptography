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

        [TestMethod()]
        public void ConvertToAsciiTest()
        {


        }

        [TestMethod()]
        public void AffineEncryptWithAdditionTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AffineEncryptWithMultiplicationTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FindMultiplicativeInversionTest()
        {
            Assert.Fail();
        }
    }
}
