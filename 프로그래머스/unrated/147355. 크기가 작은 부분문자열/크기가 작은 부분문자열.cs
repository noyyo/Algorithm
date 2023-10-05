using System;
using System.Text;

public class Solution {
    public int solution(string t, string p) {
        int count = 0;
        for (int i = 0; i < t.Length - p.Length + 1; i++)
        {
            long a = long.Parse(t.Substring(i, p.Length));
            long b = long.Parse(p);
            if (a <= b)
                count++;
        }
        return count;
    }
}