using System;
using System.Collections.Generic;

class Solution
{
    public static void Main(string[] args)
    {
        int[] count = new int['z' - 'a' + 1];
        string s = Console.ReadLine();
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            count[c - 'a']++;
        }
        for (int i = 0; i < count.Length; i++)
        {
            Console.Write(count[i].ToString() + ' ');
        }
    }
}
