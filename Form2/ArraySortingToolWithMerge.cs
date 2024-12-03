using Lab1;

namespace Lab2;

public class ArraySortingToolWithMerge: ArraySortingTool
{
    public int[] MergeSort(int[] array)
    {
        if (array.Length == 1)
        {
            return array;
        }
        int middleIndex = array.Length / 2;
        int[] firstHalf = array.Take(middleIndex).ToArray();
        int[] secondHalf = array.Skip(middleIndex).Take(array.Length - middleIndex).ToArray();
        firstHalf = MergeSort(firstHalf);
        secondHalf = MergeSort(secondHalf);
        return MergeArrays(firstHalf, secondHalf);
    }

    protected virtual int[] MergeArrays(int[] array1, int[] array2)
    {
        int[] mergedArray = new int[array1.Length + array2.Length];
        int i = 0, j = 0, k = 0;
        while (i < array1.Length && j < array2.Length)
        {
            if (array1[i] < array2[j])
            {
                mergedArray[k++] = array1[i++];
            }
            else
            {
                mergedArray[k++] = array2[j++];
            }
        }
        while (i < array1.Length)
        {
            mergedArray[k++] = array1[i++];
        }
        while (j < array2.Length)
        {
            mergedArray[k++] = array2[j++];
        }
        return mergedArray;
    }
}