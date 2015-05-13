using System;
using System.Linq;

class StuckNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] numbers = Console.ReadLine().Split(new[] {' '}, 
            StringSplitOptions.RemoveEmptyEntries).ToArray();
        bool found = false;
        for (int first = 0; first < n; first++)
        {
            for (int second = 0; second < n; second++)
            {
                for (int third = 0; third < n; third++)
                {
                    for (int forth = 0; forth < n; forth++)
                    {
                        if (first != second && first != third && first != forth &&
                            second != third && second != forth && third != forth)
                        {
                            string leftString = numbers[first] + numbers[second];
                            string rightString = numbers[third] + numbers[forth];
                            if (leftString == rightString)
                            {
                                found = true;
                                Console.WriteLine("{0}|{1}=={2}|{3}", numbers[first],
                                    numbers[second], numbers[third], numbers[forth]);
                            }
                        }
                    }
                }
            }
        }
        if (!found)
        {
            Console.WriteLine("No");
        }
    }
}