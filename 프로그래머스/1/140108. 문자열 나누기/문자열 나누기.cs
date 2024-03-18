using System;

public class Solution {
    public int solution(string s) {
        char seperator = s[0];
        int sameCount = 0;
        int differentCount = 0;
        int splitCount = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == seperator)
                sameCount++;
            else
                differentCount++;
            
            if (sameCount == differentCount)
            {
                splitCount++;
                sameCount = 0;
                differentCount = 0;
                seperator = s[i + 1];
            }
        }
        splitCount++;
        return splitCount;
    }
}