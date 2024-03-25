using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public string solution(string s, string skip, int index) {
        HashSet<char> skipSet = new HashSet<char>();
        StringBuilder sb = new StringBuilder(s);
        for (int i = 0; i < skip.Length; i++)
        {
            skipSet.Add(skip[i]);
        }
        for (int i = 0; i < sb.Length; i++)
        {
            char c = sb[i];
            for(int j = 0; j < index; j++)
            {
                c++;
                if (c > 'z')
                {
                    int excess = c - 'z' - 1;
                    c = 'a';
                    c = (char)(c + excess);
                }
                if (skipSet.Contains(c))
                {
                    j--;
                }
            }
            sb[i] = c;
        }
        return sb.ToString();
    }
}