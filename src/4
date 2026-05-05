class Result
{
    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int appleCount = 0;
        int orangeCount = 0;

        foreach (int apple in apples)
        {
            int pos = a + apple;
            if (pos >= s && pos <= t)
                appleCount++;
        }

        foreach (int orange in oranges)
        {
            int pos = b + orange;
            if (pos >= s && pos <= t)
                orangeCount++;
        }

        Console.WriteLine(appleCount);
        Console.WriteLine(orangeCount);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] first = Console.ReadLine().Split();
        int s = int.Parse(first[0]);
        int t = int.Parse(first[1]);

        string[] second = Console.ReadLine().Split();
        int a = int.Parse(second[0]);
        int b = int.Parse(second[1]);

        string[] third = Console.ReadLine().Split();
        int m = int.Parse(third[0]);
        int n = int.Parse(third[1]);

        List<int> apples = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> oranges = Console.ReadLine().Split().Select(int.Parse).ToList();

        Result.countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
