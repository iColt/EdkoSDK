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

        array.MergeSort();

        CollectionAssert.AreEqual(sortedArr, array);
    }

    [TestCaseSource(nameof(MergeSort2DimTestCases))]
    public void MergeSort2Dim_ShouldSortCorrectly(int[][] input, int[][] expected)
    {
        // Act
        input.MergeSort2Dim();

        // Assert
        Assert2DArraysEqual(expected, input);
    }

    public static object[] MergeSort2DimTestCases =
    {
        // Already sorted
        new object[]
        {
            new[]
            {
                [1, 2],
                [2, 3],
                new[] {3, 4}
            },
            new[]
            {
                [1, 2],
                [2, 3],
                new[] {3, 4}
            }
        },

        // Simple unsorted
        new object[]
        {
            new[]
            {
                [3, 4],
                [1, 2],
                new[] {2, 3}
            },
            new[]
            {
                [1, 2],
                [2, 3],
                new[] {3, 4}
            }
        },

        // Same first element, different second
        new object[]
        {
            new[]
            {
                [2, 5],
                [2, 1],
                new[] {2, 3}
            },
            new[]
            {
                [2, 5],
                [2, 1],
                new[] {2, 3}
            }
        },

        // Negative numbers
        new object[]
        {
            new[]
            {
                [-1, 5],
                [-3, 2],
                new[] {0, 0}
            },
            new[]
            {
                [-3, 2],
                [-1, 5],
                new[] {0, 0}
            }
        },

        // Single row
        new object[]
        {
            new[]
            {
                new[] {42, 100}
            },
            new[]
            {
                new[] {42, 100}
            }
        },

        // Rows with more than 2 elements
        new object[]
        {
            new[]
            {
                [1, 3, 5],
                [1, 2, 9],
                new[] {0, 10, 1}
            },
            new[]
            {
                [0, 10, 1],
                new[] {1, 3, 5},
                [1, 2, 9]
            }
        },

        // Duplicate rows
        new object[]
        {
            new[]
            {
                [1, 1],
                [1, 1],
                new[] {0, 0}
            },
            new[]
            {
                [0, 0],
                [1, 1],
                new[] {1, 1}
            }
        }
    };

    private static void Assert2DArraysEqual(int[][] expected, int[][] actual)
    {
        Assert.That(actual.Length, Is.EqualTo(expected.Length), "Row count mismatch");

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.That(actual[i].Length, Is.EqualTo(expected[i].Length), $"Column count mismatch at row {i}");

            for (int j = 0; j < expected[i].Length; j++)
            {
                Assert.That(actual[i][j], Is.EqualTo(expected[i][j]),
                    $"Mismatch at [{i}][{j}]");
            }
        }
    }
}
