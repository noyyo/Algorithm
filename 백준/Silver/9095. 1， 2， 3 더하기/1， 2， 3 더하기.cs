using System;

class Solution
{
    public static void Main()
    {
        using StreamReader sr = new StreamReader(Console.OpenStandardInput());
        using StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        
        int t = int.Parse(sr.ReadLine());
        int[] arr = new int[t];
        int[] dp = new int[11];
        for (int i = 0; i < t; i++)
        {
            arr[i] = int.Parse(sr.ReadLine());
        }
        dp[1] = 1;
        dp[2] = 2;
        dp[3] = 4;
        for (int i = 4; i < 11; i++)
            dp[i] = dp[i - 1] + dp[i - 2] + dp[i - 3];
        for (int i = 0; i < arr.Length; i++)
            sw.WriteLine(dp[arr[i]]);
    }
}