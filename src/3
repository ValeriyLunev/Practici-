using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static List<int> GradingStudents(List<int> grades)
    {
        for (int i = 0; i < grades.Count; i++)
        {
            if (grades[i] >= 38)
            {
                int remainder = grades[i] % 5;
                if (remainder >= 3)
                {
                    grades[i] += (5 - remainder);
                }
            }
        }
        return grades;
    }

    static void Main()
    {
        if (!int.TryParse(Console.ReadLine(), out int n)) return;

        List<int> grades = new List<int>();
        for (int i = 0; i < n; i++)
        {
            grades.Add(int.Parse(Console.ReadLine() ?? "0"));
        }

        List<int> result = GradingStudents(grades);
        Console.WriteLine(string.Join("\n", result));
    }
}
