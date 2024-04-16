using System;

class Solution
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n + 1];
        a[1] = 0;
        for (int i = 2; i <= n; i++)
        {
            int min = a[i - 1];
            if (i % 3 == 0)
                if (a[i / 3] < min)
                    min = a[i / 3];
            if (i % 2 == 0)
                if (a[i / 2] < min)
                    min = a[i / 2];
            a[i] = min + 1;
        }
        Console.Write(a[n]);
    }
}