using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    public static int getTotalX(List<int> a, List<int> b)
    {
        int lcmA = a[0];
        foreach (int num in a)
        {
            lcmA = LCM(lcmA, num);
        }

        int gcdB = b[0];
        foreach (int num in b)
        {
            gcdB = GCD(gcdB, num);
        }

        int count = 0;

        for (int i = lcmA; i <= gcdB; i += lcmA)
        {
            if (gcdB % i == 0)
            {
                count++;
            }
        }

        return count;
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int LCM(int a, int b)
    {
        return (a * b) / GCD(a, b);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstInput = Console.ReadLine().Split();
        int n = int.Parse(firstInput[0]);
        int m = int.Parse(firstInput[1]);

        List<int> a = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> b = Console.ReadLine().Split().Select(int.Parse).ToList();

        int result = Result.getTotalX(a, b);
        Console.WriteLine(result);
    }
}
