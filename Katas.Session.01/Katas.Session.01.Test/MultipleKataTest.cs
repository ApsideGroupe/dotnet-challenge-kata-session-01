using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Session._01.Test
{
    [TestFixture]
    public class MultipleKataTest
    {
        [TestCase(10, 23)]
        [TestCase(20, 78)]
        [TestCase(200, 9168)]
        [TestCase(0, 0)]
        [TestCase(15,50)]
        [TestCase(2,0)]
        [TestCase(-15,0)]
        [TestCase(8,14)]
        [TestCase(13,45)]
        public void SumMultiplesBelow(int input, int expected)
        {
            Assert.AreEqual(expected, MultipleKata.SumMultiplesBelow(input), $"Value: {input}");
        }
    }
}
