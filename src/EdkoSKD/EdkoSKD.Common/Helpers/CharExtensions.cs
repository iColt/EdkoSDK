namespace EdkoSKD.Common.Helpers;

public static class CharExtensions
{
    public static bool IsPalindrome(this char[] chars, int left, int right)
    {
        while (left < right)
        {
            if (chars[left] != chars[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}
