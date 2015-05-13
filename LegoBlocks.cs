using System;
using System.CodeDom;
using System.Linq;

class LegoBlocks
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[][] firstArray = new int[n][];
        int [][] secondArray = new int[n][];
        bool fit = true;
        int cellsSum = 0;
        int matrixLength = 0;
        for (int i = 0; i < n; i++)
        {
            firstArray[i] = Console.ReadLine().Split(new char[]{ ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            cellsSum += firstArray[i].Length;
        }
        for (int i = 0; i < n; i++)
        {
            secondArray[i] = Console.ReadLine().Split(new []{' '}, 
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            cellsSum += secondArray[i].Length;
            matrixLength = firstArray[0].Length + secondArray[0].Length;
            if ((firstArray[i].Length + secondArray[i].Length) != matrixLength)
            {
                fit = false;
            }
        }
        if (fit)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("[{0}, {1}]", string.Join(", ", firstArray[i]), string.Join(", ", secondArray[i].Reverse()));
            }
        }
        else
        {
            Console.WriteLine("The total number of cells is: {0}", cellsSum);
        }
    }
}
