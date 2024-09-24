using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Session._01.Test
{
    public class MinMaxKataTest
    {
        [TestCase("8 3 -5 42 -1 0 0 -9 4 7 4 -4", "42 -9")]
        [TestCase("1 2 3", "3 1")]
        [TestCase("43 20 31 -45 93", "93 -45")]
        [TestCase("-21 -20 -6 70 -7", "70 -21")]
        [TestCase("92 8 70 30 12", "92 8")]
        [TestCase("-33 68 15 52 -49", "68 -49")]
        [TestCase("73 -28 -18 27 23 -36", "73 -36")]
        public void ComputeMinMaxTest(string input, string expected)
        {
            Assert.AreEqual(expected, MinMaxKata.ComputeMinMax(input));
        }
    }
}
