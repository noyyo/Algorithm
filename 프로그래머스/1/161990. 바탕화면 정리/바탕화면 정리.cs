using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int minX = int.MaxValue;
        int minY = int.MaxValue;
        int maxX = 0;
        int maxY = 0;
        string row;
        for (int i = 0; i < wallpaper.Length; i++)
        {
            for (int j = 0; j < wallpaper[i].Length; j++)
            {
                row = wallpaper[i];
                if (row[j] != '#')
                    continue;
                
                if (j < minY)
                    minY = j;
                if (j + 1 > maxY)
                    maxY = j + 1;
                if (i < minX)
                    minX = i;
                if (i + 1 > maxX)
                    maxX = i + 1;
            }
        }
        
        int[] answer = new int[] {minX, minY, maxX, maxY};
        return answer;
    }
}