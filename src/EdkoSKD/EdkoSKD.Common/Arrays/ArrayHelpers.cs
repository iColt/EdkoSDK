namespace EdkoSKD.Common.Arrays;

public static class ArrayHelpers
{
    public static bool AreEquivalentDistinct(IList<int> a, IList<int> b)
    {
        if (a.Count != b.Count)
        {
            return false;
        }

        var sortedA = a.OrderBy(x => x).ToArray();
        var sortedB = b.OrderBy(x => x).ToArray();

        return sortedA.SequenceEqual(sortedB);
    }

}
