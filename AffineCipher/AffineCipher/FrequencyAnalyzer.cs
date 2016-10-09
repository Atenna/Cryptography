using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffineCipher
{
    public class FrequencyAnalyzer
    {
        public static int[][] FullFrequencyAnalysisDescending(string message)
        {
            char[] messageAsCharArray = ToSortedCharArray(message);
            int[][] frequencyArray = new int[messageAsCharArray.Length][];

            char currentLetter = messageAsCharArray[0];
            int count = 1;
            for (int i = 1; i < messageAsCharArray.Length; i++)
            {
                if (currentLetter == messageAsCharArray[i])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("{0}:{1}", currentLetter, count);
                    currentLetter = messageAsCharArray[i];
                    count = 1;
                }
                if (i == messageAsCharArray.Length - 1)
                {
                    Console.WriteLine("{0}:{1}", currentLetter, count);
                }
            }
            return frequencyArray;
        }

        public static char[] ToSortedCharArray(string message)
        {
            char[] sortedCharArray = message.ToCharArray();
            Array.Sort(sortedCharArray);
            return sortedCharArray;
        }

        public static char[] TopFrequency(string message)
        {
            return new char[0];
        }


    }
}
