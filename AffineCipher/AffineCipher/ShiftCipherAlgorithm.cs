using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffineCipher
{
    public class ShiftCipherAlgorithm
    {
        private Message _message;
        private List<int> _convertedMessage;
        private List<int> _encryptedMessage;
        private Key _key;
        public ShiftCipherAlgorithm(Message message, Key key)
        {
            this._message = message;
            this._key = key;
            _convertedMessage = new List<int>();
            _encryptedMessage = new List<int>();
        }
        public void Encrypt()
        {
            ConvertMessageToAscii();

            Console.WriteLine(_message.message);
            string encryptedString = "";
            foreach (char c in _convertedMessage)
            {
                int s = ((int) c + _key.Value)%26;
                _encryptedMessage.Add(s);
                encryptedString += s;
            }
            Console.WriteLine(encryptedString);
        }

        public void ConvertMessageToAscii()
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
         * Workd for upper case, lower case and spaces
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

        public void Decrypt()
        {
            string PossibleMessage = "";
            char c = ' ';
            for (int key = 0; key < 26; key++)
            {
                foreach (var number in _encryptedMessage)
                {
                    /*
                     * if (((number + key) % 26 + 65) == 91)
                    {
                        c = ' ';
                    }
                    else
                    */
                    {
                        c = (char) ((number + key)%26 + 65);
                    }
                    PossibleMessage += c;
                }
                Console.WriteLine("Key: " + (26-key) + " " + PossibleMessage);
                PossibleMessage = "";
            }
        }

        public void Decrypt(string message)
        {
            string PossibleMessage = "";
            char c = ' ';
            for (int key = 0; key < 26; key++)
            {
                foreach (var number in message)
                {
                    /*if (((number + key) % 27 + 65) == 91)
                    {
                        c = ' ';
                    }
                    else*/
                    {
                        c = (char)((number + key) % 26 + 65);
                    }
                    PossibleMessage += c;
                }
                Console.WriteLine("Key: " + (26 - key) + " " + PossibleMessage);
                PossibleMessage = "";
            }
        }
    }
}
