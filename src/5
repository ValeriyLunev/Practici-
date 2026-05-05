using System;
using System.IO;

class Result
{
    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        if (v1 <= v2)
        {
            return "NO";
        }

        if ((x2 - x1) % (v1 - v2) == 0)
        {
            return "YES";
        }

        return "NO";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        int x1 = int.Parse(input[0]);
        int v1 = int.Parse(input[1]);
        int x2 = int.Parse(input[2]);
        int v2 = int.Parse(input[3]);

        string result = Result.kangaroo(x1, v1, x2, v2);

        Console.WriteLine(result);
    }
}
