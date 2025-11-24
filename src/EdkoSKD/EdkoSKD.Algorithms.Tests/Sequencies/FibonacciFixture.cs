using EdkoSDK.Algorithms.Sequencies;

namespace EdkoSKD.Algorithms.Tests.Sequencies;

[TestFixture]
public sealed class FibonacciFixture
{
    [TestCase(1, 1)]
    [TestCase(2, 1)]
    [TestCase(3, 2)]
    [TestCase(4, 3)]
    [TestCase(5, 5)]
    [TestCase(6, 8)]
    [TestCase(7, 13)]
    [TestCase(8, 21)]
    [TestCase(9, 34)]
    public void Test_GetFibonacciBySequenceNumber(int sequenceNumber, int result)
    {
        Assert.That(Fibonacci.GetElementByNumberInSequence(sequenceNumber), Is.EqualTo(result));
    }
}
