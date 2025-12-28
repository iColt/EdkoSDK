namespace EdkoSDK.Algorithms.Arrays;

public static class Sorts
{
    #region Merge Sort

    public static void MergeSort(this int[] array)
    {
        // Merge sorted chuncks 2^n, n = [1...x] x = length / 2
        MergeSortImpl(array);
    }

    private static void MergeSortImpl(int[] array)
    {
        int chunkSize = 1;

        while(chunkSize < array.Length)
        {
            for(int i = 0; i < array.Length; i+=chunkSize*2)
            {
                MergeChunck(array, chunkSize, i);
            }

            chunkSize *= 2;
        }
    }

    private static void MergeChunck(int[] array, int chunkSize, int startPos)
    {
        int firstChunkPointer = startPos;
        int secondChunkPointer = startPos + chunkSize;

        if(secondChunkPointer >= array.Length)
        {
            return;
        }

        int operationCounter = 0;

        // use temp array as sort in one array is difficult
        int[] tempArr = new int[chunkSize * 2];


        while (operationCounter < chunkSize * 2)
        {
            if (firstChunkPointer >= startPos + chunkSize && (secondChunkPointer >= startPos + chunkSize * 2 || secondChunkPointer >= array.Length))
            {
                break;
            }

            if(firstChunkPointer >= startPos + chunkSize)
            {
                tempArr[operationCounter] = array[secondChunkPointer];
                secondChunkPointer++;
            } else if (secondChunkPointer >= startPos + chunkSize * 2 || secondChunkPointer >= array.Length)
            {
                tempArr[operationCounter] = array[firstChunkPointer];
                firstChunkPointer++;
            } else
            {
                if (array[firstChunkPointer] <= array[secondChunkPointer])
                {
                    tempArr[operationCounter] = array[firstChunkPointer];
                    firstChunkPointer++;
                }
                else
                {
                    tempArr[operationCounter] = array[secondChunkPointer];
                    secondChunkPointer++;
                }
            }

            operationCounter++;
        }
       
        for( int i = startPos; i < startPos + operationCounter; i++)
        {
            array[i] = tempArr[i - startPos];
        }
    }

    #endregion

    #region Merge sort 2 dim
    /// <summary>
    /// Merge 2 Dim. array using first element as a key
    /// </summary>
    /// <param name="array"></param>

    public static void MergeSort2Dim(this int[][] array)
    {
        // Merge sorted chuncks 2^n, n = [1...x] x = length / 2
        MergeSortImpl2Dim(array);
    }

    private static void MergeSortImpl2Dim(int[][] array)
    {
        int chunkSize = 1;

        while (chunkSize < array.Length)
        {
            for (int i = 0; i < array.Length; i += chunkSize * 2)
            {
                MergeChunck2Dim(array, chunkSize, i);
            }

            chunkSize *= 2;
        }
    }

    private static void MergeChunck2Dim(int[][] array, int chunkSize, int startPos)
    {
        int firstChunkPointer = startPos;
        int secondChunkPointer = startPos + chunkSize;

        if (secondChunkPointer >= array.Length)
        {
            return;
        }

        int operationCounter = 0;

        // use temp array as sort in one array is difficult
        int[][] tempArr = new int[chunkSize * 2][];


        while (operationCounter < chunkSize * 2)
        {
            if (firstChunkPointer >= startPos + chunkSize && (secondChunkPointer >= startPos + chunkSize * 2 || secondChunkPointer >= array.Length))
            {
                break;
            }

            if (firstChunkPointer >= startPos + chunkSize)
            {
                tempArr[operationCounter] = array[secondChunkPointer];
                secondChunkPointer++;
            }
            else if (secondChunkPointer >= startPos + chunkSize * 2 || secondChunkPointer >= array.Length)
            {
                tempArr[operationCounter] = array[firstChunkPointer];
                firstChunkPointer++;
            }
            else
            {
                if (array[firstChunkPointer][0] <= array[secondChunkPointer][0])
                {
                    tempArr[operationCounter] = array[firstChunkPointer];
                    firstChunkPointer++;
                }
                else
                {
                    tempArr[operationCounter] = array[secondChunkPointer];
                    secondChunkPointer++;
                }
            }

            operationCounter++;
        }

        for (int i = startPos; i < startPos + operationCounter; i++)
        {
            array[i] = tempArr[i - startPos];
        }
    }

    #endregion
}
