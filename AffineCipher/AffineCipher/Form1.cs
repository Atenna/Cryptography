using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AffineCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShiftCipherAlgorithm al = new ShiftCipherAlgorithm(new Message("AHOJ IVKA A TONOO"), new Key(12));
            //al.Encrypt();
            al.Decrypt("DATG");
        }
    }
}
