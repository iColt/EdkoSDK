namespace EdkoSDK.Algorithms.Sequencies;

public static class Fibonacci
{
    public static int GetElementByNumberInSequence(int n)
    {
        if (n <= 2)
        {
            return 1;
        }

        int previousValue = 1;
        int result = 1;

        for (int i = 2; i < n; i++)
        {
            int tmp = result;
            result += previousValue;
            previousValue = tmp;
        }
        return result;
    }
}
