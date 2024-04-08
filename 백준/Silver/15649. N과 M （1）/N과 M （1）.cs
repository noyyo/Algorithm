using System;

class Solution
{
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] sSplit = s.Split(" ");
        int n = int.Parse(sSplit[0]);
        int m = int.Parse(sSplit[1]);
        int[] arr = new int[10];
        bool[] isUsed = new bool[10];
        using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
        {
            Console.SetOut(sw);
            back(0, n, m, arr, isUsed);
        }
    }
    private static void back(int k, in int n, in int m, int[] arr, bool[] isUsed)
    {
        if (k == m)
        {
            for (int i = 0; i < m; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }
        for (int i = 1; i <= n; i++)
        {
            if (!isUsed[i])
            {
                arr[k] = i;
                isUsed[i] = true;
                back(k + 1, in n, in m, arr, isUsed);
                isUsed[i] = false;
            }
        }

    }
}