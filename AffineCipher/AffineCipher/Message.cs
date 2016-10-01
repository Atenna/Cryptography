using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffineCipher
{
    public class Message
    {
        public string message { get; private set; }
        public Message(string message)
        {
            this.message = message;
        }
    }
}
