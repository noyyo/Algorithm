using System;

class Solution
{
    public static void Main()
    {
        using StreamReader sr = new StreamReader(Console.OpenStandardInput());
        int n = int.Parse(sr.ReadLine());
        int[ , ] dp = new int[n + 1, 3];
        int[] costs = new int[(n + 1) * 3];
        
        for (int i = 1; i <= n; i++)
        {
            string[] split = sr.ReadLine().Split();
            costs[i * 3 - 2] = int.Parse(split[0]);
            costs[i * 3 - 1] = int.Parse(split[1]);
            costs[i * 3] = int.Parse(split[2]);
        }
        dp[1, 0] = costs[1];
        dp[1, 1] = costs[2];
        dp[1, 2] = costs[3];
        
        for (int i = 2; i <= n; i++)
        {
            dp[i, 0] = Math.Min(dp[i - 1, 1], dp[i - 1, 2]) + costs[i * 3 - 2];
            dp[i, 1] = Math.Min(dp[i - 1, 0], dp[i - 1, 2]) + costs[i * 3 - 1];
            dp[i, 2] = Math.Min(dp[i - 1, 0], dp[i - 1, 1]) + costs[i * 3];
        }
        Console.Write(Math.Min(Math.Min(dp[n, 0], dp[n, 1]), dp[n,2]));
    }
}