using Microsoft.VisualStudio.TestTools.UnitTesting;
using AffineCipher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffineCipher.Tests
{
    [TestClass()]
    public class FrequencyAnalyzerTests
    {
        [TestMethod()]
        public void ToSortedCharArrayTest()
        {
            char[] arr = { 'A', 'A', 'F', 'R', 'Z', 'Z', 'Z' };

            char[] arr2 = FrequencyAnalyzer.ToSortedCharArray("AFAZZRZ");
            Assert.Equals(arr, arr2);
        }

        [TestMethod()]
        public void FullFrequencyAnalysisDescendingTest()
        {
            int[][] sprava = FrequencyAnalyzer.FullFrequencyAnalysisDescending("AHOJ AHOJ CAU");
            
        }
    }
}