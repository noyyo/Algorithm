using System;

class Solution
{
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] sSplit = s.Split(" ");
        int a = int.Parse(sSplit[0]);
        int b = int.Parse(sSplit[1]);
        int c = int.Parse(sSplit[2]);
        
        long mod = a % c;
        long result = 1;
        while (b > 0)
        {
            if ((b & 1) == 1)
                result = result * mod % c;

                b >>= 1;
                mod = mod * mod % c;
        }
        
        Console.WriteLine(result);
    }
}