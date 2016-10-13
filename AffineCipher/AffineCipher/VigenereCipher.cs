using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffineCipher
{
    class VigenereCipher
    {
        public static void Encrypt(string message, string key)
        {
            char[] plainText = message.ToCharArray();
            char[] keyText = key.ToCharArray();
            string encryptedMessage = "";

            for (int i = 0; i < message.Length; i++)
            {
                var convertedLetter = ConvertCharToAscii(plainText[i]);
                var convertedKey = ConvertCharToAscii(keyText[i%key.Length]);
                var encryptedLetter = ConvertAsciiToChar(convertedLetter + convertedKey);
                encryptedMessage += encryptedLetter;
            }
            Console.WriteLine(encryptedMessage);
        }

        public static void Decrypt(string s, string key)
        {
            StringBuilder builder = new StringBuilder();
            char[] message = s.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                if (message[i] < 65 || message[i] > 90)
                {
                    char decyphered = ' ';
                    if (ConvertCharToAscii(message[i]) - GetShift(key, i) < 65)
                    {
                        decyphered = (char) ((ConvertCharToAscii(message[i]) - GetShift(key, i)) + 26);
                    }
                    else
                    {
                        decyphered = (char) (ConvertCharToAscii(message[i]) - GetShift(key, i));
                    }
                    builder.Append(decyphered);
                }
                Console.WriteLine(builder.ToString());
            }
        }

        public static int GetShift(string key, int i)
        {
            char[] keyMessage = key.ToCharArray();
            if (keyMessage[i] < 65 || keyMessage[i % key.Length] > 90)
            {
                return ConvertCharToAscii(keyMessage[i % key.Length]) - 65;
            }
            return -1;
        }


        public static char ConvertAsciiToChar(int number)
        {
            if (number >= 0 && number <= 25)
            {
                return (char)(number + 'A');
            }
            return ' ';
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
    }
}
