namespace EdkoSDK.Algorithms.Sequencies;

public static class Fibonacci
{
    public static int GetElementByNumberInSequence(int n)
    {
        if (n <= 3)
        {
            return n;
        }

        int previousValue = 2;
        int result = 3;

        for (int i = 3; i < n; i++)
        {
            int tmp = result;
            result += previousValue;
            previousValue = tmp;
        }
        return result;
    }
}
