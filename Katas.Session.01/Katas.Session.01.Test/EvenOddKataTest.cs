namespace Katas.Session._01.Test;

[TestFixture]
public class EvenOddKataTest
{
    [TestCase(1)]
    [TestCase(7)]
    public void PositiveOddTest(int input)
    {
        Assert.AreEqual("Odd", EvenOddKata.EvenOrOdd(input));
    }

    [TestCase(2)]
    [TestCase(42)]
    public void PositiveEvenTest(int input)
    {
        Assert.AreEqual("Even", EvenOddKata.EvenOrOdd(input));
    }

    [TestCase(-1)]
    [TestCase(-7)]
    public void NegativeOddTest(int input)
    {
        Assert.AreEqual("Odd", EvenOddKata.EvenOrOdd(input));
    }

    [TestCase(-2)]
    [TestCase(-42)]
    public void NegativeEvenTest(int input)
    {
        Assert.AreEqual("Even", EvenOddKata.EvenOrOdd(input));
    }

    [Test]
    public void ZeroIsEvenTest()
    {
        Assert.AreEqual("Even", EvenOddKata.EvenOrOdd(0));
    }
}
