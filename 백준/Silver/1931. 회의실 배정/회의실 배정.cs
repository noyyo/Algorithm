using System;
using System.Linq;

class Solution
{
    public static void Main()
    {
        using StreamReader sr = new StreamReader(Console.OpenStandardInput());
        int n = int.Parse(sr.ReadLine());
        (int start, int end)[] meetings = new (int start, int end)[n];
        for (int i = 0; i < n; i++)
        {
            string[] split = sr.ReadLine().Split();
            int s = int.Parse(split[0]);
            int e = int.Parse(split[1]);
            meetings[i] = (s, e);
        }
        meetings = meetings.OrderBy(x => x.end).ThenBy(x => x.start).ToArray();
        int count = 0;
        int lastEndTime = -1;
        for (int i = 0; i < n; i++)
        {
            if (meetings[i].start == meetings[i].end && meetings[i].start >= lastEndTime)
            {
                count++;
                lastEndTime = meetings[i].end;
                continue;
            }
            if (meetings[i].start < lastEndTime)
                continue;
            count++;
            lastEndTime = meetings[i].end;
        }
        Console.Write(count);
    }
}