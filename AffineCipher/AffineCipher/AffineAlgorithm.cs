using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffineCipher
{
    class AffineAlgorithm
    {
        private Message _message;
        private List<int> _convertedMessage;
        private List<int> _encryptedMessage;
        private Key _key;
        public AffineAlgorithm(Message message, Key key)
        {
            this._message = message;
            this._key = key;
            _convertedMessage = new List<int>();
            _encryptedMessage = new List<int>();
        }
        public void Encrypt()
        {
            ConvertToAscii();

            Console.WriteLine(_message.message);
            string encryptedString = "";
            foreach (char c in _convertedMessage)
            {
                int s = ((int) c + _key.Value)%27;
                _encryptedMessage.Add(s);
                encryptedString += s;
            }
            Console.WriteLine(encryptedString);
        }

        public void ConvertToAscii()
        {
            // kazde pismeno na cislo
            int n = 0;
            char[] msg = _message.message.ToCharArray();
            string asciiString = "";
            foreach (char c in msg)
            {
                n = c == ' ' ? 26 : ((int)c) - 65;
                asciiString += n;
                _convertedMessage.Add(n);
            }
            Console.WriteLine(asciiString);
        }

        public void Decrypt()
        {
            string PossibleMessage = "";
            char c = ' ';
            for (int key = 0; key < 27; key++)
            {
                foreach (var number in _encryptedMessage)
                {
                    if (((number + key) % 27 + 65) == 91)
                    {
                        c = ' ';
                    }
                    else
                    {
                        c = (char) ((number + key)%27 + 65);
                    }
                    PossibleMessage += c;
                }
                Console.WriteLine("Key: " + (27-key) + " " + PossibleMessage);
                PossibleMessage = "";
            }
        }
    }
}
