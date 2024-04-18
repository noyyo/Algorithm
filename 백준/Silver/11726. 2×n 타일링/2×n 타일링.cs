using System;

class Solution
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] dp = new int[n + 1];
        dp[1] = 1;
        if (n >= 2)
            dp[2] = 2;
        for (int i = 3; i <= n; i++)
            dp[i] = (dp[i - 1] + dp[i - 2]) % 10007;
        
        Console.Write(dp[n]);
    }
}