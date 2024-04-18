using System;
using System.Text;
class Solution
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] dp = new int[n + 1];
        int[] route = new int[n + 1];
        dp[1] = 0;
        for (int i = 2; i <= n; i++)
        {
            int count = dp[i - 1] + 1;
            route[i] = i - 1;
            if (i % 3 == 0 && dp[i / 3] + 1 < count)
            {
                count = dp[i / 3] + 1;
                route[i] = i / 3;
            }
            if (i % 2 == 0 && dp[i / 2] + 1 < count)
            {
                count = dp[i / 2] + 1;
                route[i] = i / 2;
            }
            dp[i] = count;
        }
        Console.WriteLine(dp[n]);
        StringBuilder sb = new StringBuilder();
        while(n != 1)
        {
            sb.Append(n.ToString());
            sb.Append(' ');
            n = route[n];
        }
        sb.Append('1');
        Console.WriteLine(sb.ToString());
    }
}