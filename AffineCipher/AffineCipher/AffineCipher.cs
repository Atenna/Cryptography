using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffineCipher
{
    class AffineCipher
    {
        public static void Encrypt(string message, int a, int b)
        {
            char[] plaintext = message.ToCharArray();
            string encryptedMessage = "";

            foreach (char letterToEncrypt in plaintext)
            {
                var convertedInt = ConvertCharToAscii(letterToEncrypt);
                var encryptedLetter = ConvertAsciiToChar(Modulo((a * convertedInt + b), 27));
                encryptedMessage += encryptedLetter;
            }
            Console.WriteLine(encryptedMessage);
        }

        public static void Decrypt(string message)
        {
            char[] plaintext = message.ToCharArray();
            string decryptedMessage = "";

            for (int a = 0; a < 27; a++)
            {
                for (int b = 0; b < 27; b++)
                {

                    for (int i = 0; i < message.Length; i++)
                    {
                        var convertedInt = ConvertCharToAscii(plaintext[i]);
                        var decryptedInt = Modulo(a * (convertedInt - b), 27);
                        var decryptedLetter = ConvertAsciiToChar(decryptedInt);
                        decryptedMessage += decryptedLetter;
                    }

                    Console.WriteLine("A: {0}, B: {1}   {2}",a,b,decryptedMessage);
                    decryptedMessage = "";
                }
            }
        }

        public static void Decrypt(string message, int a, int b)
        {
            char[] plaintext = message.ToCharArray();
            string decryptedMessage = "";
            for (int i = 0; i < message.Length; i++)
            {
                var convertedInt = ConvertCharToAscii(plaintext[i]);
                var decryptedInt = Modulo(a * (convertedInt - b), 27);
                var decryptedLetter = ConvertAsciiToChar(decryptedInt);
                decryptedMessage += decryptedLetter;
            }

            Console.WriteLine("A: {0}, B: {1}   {2}", a, b, decryptedMessage);
            decryptedMessage = "";
        }

        public static int Modulo(int x, int m)
        {
           return (x % m + m) % m;
        }

        public static void ConvertMessageToAscii(string message)
        {
            // kazde pismeno na cislo
            int n = 0;
            char[] msg = message.ToCharArray();
            string asciiString = "";
            foreach (char c in msg)
            {
                n = ConvertCharToAscii(c);
                asciiString += n;
            }
            Console.WriteLine(asciiString);
        }

        public static int ConvertCharToAscii(char letter)
        {
            // for capitals
            if (letter >= 'A' && letter <= 'Z')
            {
                return letter - 'A';
            }
            // for lower case
            if (letter >= 'a' && letter <= 'z')
            {
                return letter - 'a';
            }
            // for space
            return 26;
        }

        public static char ConvertAsciiToChar(int number)
        {
            if (number >= 0 && number <= 25)
            {
                return (char)(number + 'A');
            }
            return ' ';
        }

        public static int FindMultiplicativeInversion(int a)
        {
            for (int i = 0; i < 27; i++)
            {
                if (AffineEncryptWithMultiplication(a, i, 0) == 1)
                {
                    return i;
                }
            }
            return 0;
        }

        public static int AffineEncryptWithAddition(int a, int b)
        {
            return (a + b) % 27;
        }

        public static int AffineEncryptWithMultiplication(int a, int b, int letter)
        {
            return (a * b) % 27;
        }
    }
}
