using System;

class Solution
{
    int n;
    int s;
    int count = 0;
    int[] arr;
    public Solution()
    {
        string str = Console.ReadLine();
        string[] sSplit = str.Split(" ");
        n = int.Parse(sSplit[0]);
        s = int.Parse(sSplit[1]);
        arr = new int[n];
        str = Console.ReadLine();
        sSplit = str.Split(" ");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(sSplit[i]);
    }
    public static void Main()
    {
        Solution sol = new Solution();
        sol.Back(0, 0);
        if (sol.s == 0)
            sol.count--;
        Console.Write(sol.count);
    }
    private void Back(int k, int sum)
    {
        if (k == n)
        {
            if (sum == s)
                count++;
            return;
        }
        Back(k + 1, sum);
        Back(k + 1, sum + arr[k]);
    }
}