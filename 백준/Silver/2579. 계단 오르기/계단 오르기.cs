using System;

class Solution
{
    public static void Main()
    {
        using StreamReader sr = new StreamReader(Console.OpenStandardInput());
        int n = int.Parse(sr.ReadLine());
        int[] stairs = new int[n + 1];
        for (int i = 1; i <= n; i++)
            stairs[i] = int.Parse(sr.ReadLine());
        
        int[] dp = new int[n + 1];
        dp[1] = stairs[1];
        if (n >= 2)
            dp[2] = stairs[1] + stairs[2];
        for (int i = 3; i <= n; i++)
        {
            int max = dp[i - 2] + stairs[i];
            max = Math.Max(max, dp[i - 3] + stairs[i - 1] + stairs[i]);
            dp[i] = max;
        }
        Console.Write(dp[n]);
    }
}