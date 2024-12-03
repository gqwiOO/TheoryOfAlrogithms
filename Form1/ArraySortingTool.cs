namespace Lab1;

public class ArraySortingTool
{
    public virtual int[] InsertingSort(int[] array)
    {
        var count = array.Length;

        int[] sortResult = new int[array.Length];
        for (var i = 0; i < array.Length; i++)
            sortResult[i] = array[i];
        
        for (int i = 1; i < count; i++)
        {
            for (int j = i; j > 0; j--)
            {
                if (sortResult[j] < sortResult[j - 1])
                    (sortResult[j], sortResult[j - 1]) = (sortResult[j - 1], sortResult[j]);
            }
        }

        return sortResult;
    }

    public int[] BubbleSort(int[] array)
    {
        var count = array.Length;

        int[] sortResult = new int[array.Length];
        for (var i = 0; i < array.Length; i++)
            sortResult[i] = array[i];
        
        while (true)
        {
            bool withReplacements = false;
            for (int i = 1; i < count; i++)
            {
                if (sortResult[i] < sortResult[i - 1])
                {
                    (sortResult[i], sortResult[i - 1]) = (sortResult[i - 1], sortResult[i]);
                    withReplacements = true;
                }
            }
            if (!withReplacements)
                break;
        }
        
        return sortResult;

    }
}