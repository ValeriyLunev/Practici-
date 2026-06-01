using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    static int migratoryBirds(List<int> arr)
    {
        int[] count = new int[6];

        foreach (int bird in arr)
        {
            count[bird]++;
        }

        int max = 0;
        int result = 0;

        for (int i = 1; i <= 5; i++)
        {
            if (count[i] > max)
            {
                max = count[i];
                result = i;
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        List<int> arr = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        Console.WriteLine(migratoryBirds(arr));
    }
}
