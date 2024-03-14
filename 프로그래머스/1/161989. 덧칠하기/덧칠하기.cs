using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int paintStartSection = section[0];
        int paintCount = 1;
        for (int i = 1; i < section.Length; i++)
        {
            if (section[i] - paintStartSection < m)
            {
                continue;
            }
            else
            {
                paintCount++;
                paintStartSection = section[i];
            }
        }
        
        return paintCount;
    }
}