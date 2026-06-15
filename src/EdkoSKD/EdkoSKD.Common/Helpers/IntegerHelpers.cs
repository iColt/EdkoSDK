namespace EdkoSKD.Common.Helpers;

public static class IntegerHelpers
{
    public static int[] ConvertToArrayOfDigits(this int number)
    {
        int numberLength = 0;
        //x < 2^31
        int[] arrNumber = new int[10];
        while (true)
        {
            arrNumber[numberLength] = number % 10;
            number = number / 10;
            numberLength++;

            if (number == 0)
            {
                break;
            }
        }

        return arrNumber;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="number"></param>
    /// <param name="lowerBoundary">Lower boundary to reduce factorial in combinatory tasks</param>
    /// <returns></returns>
    public static decimal Factorial(this int number, int lowerBoundary = 1)
    {
        if(number == lowerBoundary)
        {
            return lowerBoundary;
        }

        return number * Factorial(--number, lowerBoundary);
    }

    public static int PowerOfTwo(this int number)
    {
        if (number == 0)
        {
            return 1;
        }

        if(number > 16)
        {
            throw new ArgumentException("Integer does not support value");
        }
        int result = 2;
        for(int i  = 0; i < number; i++)
        {
            result = result * number;
        }

        return result;
    }

}
