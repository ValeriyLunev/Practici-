using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static List<int> breakingRecords(List<int> scores)
    {
        int maxScore = scores[0];
        int minScore = scores[0];

        int maxBreaks = 0;
        int minBreaks = 0;

        for (int i = 1; i < scores.Count; i++)
        {
            if (scores[i] > maxScore)
            {
                maxScore = scores[i];
                maxBreaks++;
            }
            else if (scores[i] < minScore)
            {
                minScore = scores[i];
                minBreaks++;
            }
        }

        return new List<int> { maxBreaks, minBreaks };
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(Console.OpenStandardOutput());

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine()
            .TrimEnd()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        List<int> result = Result.breakingRecords(scores);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
    }
}
