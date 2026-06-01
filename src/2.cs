using System;

class Program
{
    static void Staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(new string(' ', n - i) + new string('#', i));
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Staircase(n);
    }
}
