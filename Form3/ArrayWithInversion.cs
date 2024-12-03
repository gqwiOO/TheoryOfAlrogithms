using Lab2;

namespace Lab3;

public class ArrayToolWithInversions : ArraySortingToolWithMerge
{
    public int TotalInversions { get; private set; } = 0;

    protected override int[] MergeArrays(int[] leftArray, int[] rightArray)
    {
        int[] result = new int[leftArray.Length + rightArray.Length];
        int leftIndex = 0, rightIndex = 0, resultIndex = 0;

        while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
        {
            if (leftArray[leftIndex] <= rightArray[rightIndex])
            {
                result[resultIndex++] = leftArray[leftIndex++];
            }
            else
            {
                result[resultIndex++] = rightArray[rightIndex++];
                TotalInversions += leftArray.Length - leftIndex;
            }
        }

        while (leftIndex < leftArray.Length)
        {
            result[resultIndex++] = leftArray[leftIndex++];
        }

        while (rightIndex < rightArray.Length)
        {
            result[resultIndex++] = rightArray[rightIndex++];
        }

        return result;
    }

    public override int[] InsertingSort(int[] array)
    {
        for (int current = 1; current < array.Length; current++)
        {
            for (int prev = current; prev > 0; prev--)
            {
                if (array[prev] < array[prev - 1])
                {
                    (array[prev], array[prev - 1]) = (array[prev - 1], array[prev]);
                    TotalInversions++;
                }
            }
        }

        return array;
    }
}