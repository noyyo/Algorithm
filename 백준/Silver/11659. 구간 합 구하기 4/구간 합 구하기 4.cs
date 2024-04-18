using System;

class Solution
{
    public static void Main()
    {
        using StreamReader sr = new StreamReader(Console.OpenStandardInput());
        using StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        string[] split = sr.ReadLine().Split();
        int n = int.Parse(split[0]);
        int m = int.Parse(split[1]);
        int[] dp = new int[n + 1];
        split = sr.ReadLine().Split();
        for (int i = 1; i <= n; i++)
            dp[i] = dp[i - 1] + int.Parse(split[i - 1]);
        for (int k = 0; k < m; k++)
        {
            split = sr.ReadLine().Split();
            int i = int.Parse(split[0]);
            int j = int.Parse(split[1]);
            sw.WriteLine(dp[j] - dp[i - 1]);
        }
    }
}