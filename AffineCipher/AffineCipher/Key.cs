using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffineCipher
{
    public class Key
    {
        public int Value { get; private set; }
        public Key(int key)
        {
            this.Value = key;
        }
    }
}
