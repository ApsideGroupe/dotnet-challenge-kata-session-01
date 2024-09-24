using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Session._01.Test
{
    [TestFixture]
    public class ReverseStringKataTest
    {
        [TestCase("Hello World", "World Hello")]
        [TestCase("There. Hi", "Hi There.")]
        [TestCase("I am an expert at this", "this at expert an am I")]
        [TestCase("Yes we can!", "can! we Yes")]
        [TestCase("survive to Drive", "Drive to survive")]
        [TestCase("thrones of game A", "A game of thrones")]
        [TestCase("L'hymne de nos campagnes", "campagnes nos de L'hymne")]
        public void ReverseWordTest(string input, string expected)
        {
            Assert.AreEqual(expected, ReverseStringKata.ReverseWords(input));
        }
    }
}
