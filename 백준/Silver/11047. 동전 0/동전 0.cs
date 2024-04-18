using System;

class Solution
{
    public static void Main()
    {
        string[] split = Console.ReadLine().Split();
        int n = int.Parse(split[0]);
        int k = int.Parse(split[1]);
        int[] coinValues = new int[n];
        for (int i = 0; i < n; i++)
            coinValues[i] = int.Parse(Console.ReadLine());
        
        int coin = 0;
        int index = coinValues.Length - 1;
        while (k != 0)
        {
            while (coinValues[index] > k)
                index--;
            k -= coinValues[index];
            coin++;
        }
        Console.Write(coin);
    }
}