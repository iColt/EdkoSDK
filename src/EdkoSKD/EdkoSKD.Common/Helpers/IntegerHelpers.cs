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

}
