using EdkoSKD.Common.Helpers;

namespace EdkoSDK.Common.Tests.Helpers;

[TestFixture]
public class RomanToIntegerFixture
{

    [TestCase("MCMXCIV", 1994)]
    [TestCase("I", 1)]
    [TestCase("II", 2)]
    [TestCase("III", 3)]
    [TestCase("IV", 4)]
    [TestCase("LVIII", 58)]
    public void Test_RomanToInt(string s, int number)
    {
        Assert.That(s.ConvertFromRomanToInteger(), Is.EqualTo(number));
    }

    [Test]
    public void Test_RomanToInteger_NotARoman_Throw()
    {
        Assert.Throws<ArgumentException>(() => { "ABC".ConvertFromRomanToInteger(); });
    }
}
