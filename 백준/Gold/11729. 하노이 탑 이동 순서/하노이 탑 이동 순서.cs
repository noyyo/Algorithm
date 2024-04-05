using System;

class Solution
{
    public static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        using StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        sw.AutoFlush = false;
        Console.SetOut(sw);
        Console.WriteLine((1 << k) - 1);
        Hanoi(1, 3, k);
        sw.Flush();
    }
    private static void Hanoi(int a, int b, int n)
    {
        if (n <= 0)
            return;
        Hanoi(a, 6 - a - b, n - 1);
        Console.Write($"{a} {b}\n");
        Hanoi(6 - a - b, b, n - 1);
    }
}