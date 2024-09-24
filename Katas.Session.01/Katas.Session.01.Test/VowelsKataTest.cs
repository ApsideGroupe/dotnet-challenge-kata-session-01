using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Session._01.Test
{
    [TestFixture]
    public class VowelsKataTest
    {
        [TestCase("transatlantique", 6)]
        [TestCase("clignotement", 4)]
        [TestCase("chandail", 3)]
        [TestCase("skyr", 0)]
        [TestCase("tourista", 4)]
        [TestCase("rayon", 2)]
        public void TestCase(string input, int expected)
        {
            Assert.AreEqual(expected, VowelsKata.CountVowels(input));
        }
    }
}
