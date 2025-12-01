using System.Text;

namespace EdkoSKD.Common.Helpers;

public static class RomanToInteger
{
    public static int ConvertFromRomanToInteger(this string s)
    {
        if(s.AsSpan().IndexOfAnyExcept("IVXLCDM") != -1)
        {
            throw new ArgumentException($"String <{s}> is not a Roman Integer");
        }

        var map = new Dictionary<char, int>
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000
        };

        int total = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int value = map[s[i]];

            if (i + 1 < s.Length && map[s[i + 1]] > value)
            {
                total -= value;
            }
            else
            {
                total += value;
            }
        }

        return total;
    }

    public static string ConvertFromIntegerToRoman(this int number)
    {
        if(number < 0)
        {
            throw new NotImplementedException();
        }

        if(number == 0)
        {
            throw new ArgumentException("There is no zero in Roman numerals");
        }

        var sb = new StringBuilder();

        int[] digits = number.ConvertToArrayOfDigits();

        return sb.ToString();
    }
}
