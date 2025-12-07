using EdkoSDK.Algorithms.Arrays;

namespace EdkoSKD.Algorithms.Tests.Arrays;

[TestFixture]
public class SortsFixture
{
    [TestCase(new[] { 1, 10, 4, 8, 0, -5, 1, -100, 100, 3 })]
    [TestCase(new[] {1, 10, 4, 8, 0, -5, 1})]
    public void Test_Sorts(int[] array)
    {
        int[] sortedArr = new int[array.Length];
        Array.Copy(array, sortedArr, array.Length);
        Array.Sort(sortedArr);

        Sorts.MergeSort(array);

        CollectionAssert.AreEqual(sortedArr, array);
    }
}
