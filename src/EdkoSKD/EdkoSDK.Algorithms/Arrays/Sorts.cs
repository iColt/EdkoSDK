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

        //while(operationCounter < chunkSize)
        //{
        //    if(secondChunkPointer >= array.Length || firstChunkPointer > startPos + chunkSize || secondChunkPointer > startPos + chunkSize * 2)
        //    {
        //        break;
        //    }

        //    if (array[firstChunkPointer] <= array[secondChunkPointer])
        //    {
        //        firstChunkPointer++;
        //    } else
        //    {
        //        int temp = array[secondChunkPointer];
        //        array[secondChunkPointer] = array[firstChunkPointer];
        //        array[firstChunkPointer] = temp;
        //        secondChunkPointer++;
        //    }

        //    operationCounter++;
            
        //}
    }

    #endregion
}
