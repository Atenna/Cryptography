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
            //ShiftCipherAlgorithm al = new ShiftCipherAlgorithm(new Message("AHOJ IVKA A TONOO"), new Key(12));
            //FrequencyAnalyzer.FullFrequencyAnalysisDescending("LIYGTOGDPOAUPDFQNVPVDAQV");
            /*
            int inverse = ShiftCipherAlgorithm.FindMultiplicativeInversion(3);
            Console.WriteLine("Inversed element to D={0} is {1}", 3, inverse);
            inverse = ShiftCipherAlgorithm.FindMultiplicativeInversion(13);
            Console.WriteLine("Inversed element to P={0} is {1}", 13, inverse);
            inverse = ShiftCipherAlgorithm.FindMultiplicativeInversion(21);
            Console.WriteLine("Inversed element to V={0} is {1}", 21, inverse);
            */
            AffineCipher.Encrypt("VYRIESIL SOM LAHKU ULOHU", 8,5);
            AffineCipher.Decrypt("LIGPKOPMYOJUYMFHEDYDMJHD", 17,5);
            //AffineCipher.Decrypt("LIYGTOGDPOAUPDFQNVPVDAQV");
        }
    }
}
