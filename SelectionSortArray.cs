using System;
using System.Linq;

class SelectionSortArray
{
    static void Main()
    {
        int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
        SelectionSort(inputArray);
        Console.WriteLine(String.Join(" ", inputArray));
    }
    static int[] SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minValue = array[i];
            int index = 0;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (minValue > array[j])
                {
                    minValue = array[j];
                    index = j;
                }
            }
            if (minValue != array[i])
            {
                int tempValue = array[i];
                array[i] = minValue;
                array[index] = tempValue;
            }
        }
        return array;
    }
}
