using System;

class BiggerNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int max = GetMax(firstNumber, secondNumber);
        Console.WriteLine(max);
    }

    static int GetMax(int firstNum, int secondNum)
    {
        int max = firstNum > secondNum ? firstNum : secondNum;
        return max;
    }
}