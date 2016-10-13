using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffineCipher
{
    public class ShiftCipherAlgorithm
    {
        private static Message _message;
        private static List<int> _convertedMessage;
        private static List<int> _encryptedMessage;
        private static Key _key;
        public ShiftCipherAlgorithm(Message message, Key key)
        {
            ShiftCipherAlgorithm._message = message;
            ShiftCipherAlgorithm._key = key;
            _convertedMessage = new List<int>();
            _encryptedMessage = new List<int>();
        }
        public static void Encrypt()
        {
            ConvertMessageToAscii();

            Console.WriteLine(_message.message);
            string encryptedString = "";
            foreach (char c in _convertedMessage)
            {
                int s = AffineEncryptWithMultiplication(c, _key.Value);
                _encryptedMessage.Add(s);
                encryptedString += s;
            }
            Console.WriteLine(encryptedString);
        }

        public static void ConvertMessageToAscii()
        {
            // kazde pismeno na cislo
            int n = 0;
            char[] msg = _message.message.ToCharArray();
            string asciiString = "";
            foreach (char c in msg)
            {
                n = ConvertCharToAscii(c);
                asciiString += n;
                _convertedMessage.Add(n);
            }
            Console.WriteLine(asciiString);
        }

        /*
         * Works for upper case, lower case and spaces
         */
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
                if( AffineEncryptWithMultiplication(a,i) == 1 )
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

        public static int AffineEncryptWithMultiplication(int a, int b)
        {
            return (a * b) % 27;
        }

        public void Decrypt()
        {
            string PossibleMessage = "";
            char c = ' ';
            for (int a = 0; a < 26; a++)
            {
                for (int b = 0; b < 26; b++)
                {
                    
                }
            }
        }

        public static void Decrypt(string message)
        {
            
        }
    }
}
