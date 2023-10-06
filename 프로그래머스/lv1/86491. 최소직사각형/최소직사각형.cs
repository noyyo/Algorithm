using System;

public class Solution {
    public int solution(int[,] sizes) {
        int maxBigSize = 0;
        int maxSmallSize = 0;
        int bigSize;
        int smallSize;
        for (int i = 0; i < sizes.Length / 2; i++)
        {
            if (sizes[i,0] > sizes[i,1])
            {
                bigSize = sizes[i,0];
                smallSize = sizes[i,1];
            }
            else
            {
                bigSize = sizes[i,1];
                smallSize = sizes[i,0];
            }
            if (bigSize > maxBigSize)
                maxBigSize = bigSize;
            if (smallSize > maxSmallSize)
                maxSmallSize = smallSize;
        }
        return maxBigSize * maxSmallSize;
    }
}