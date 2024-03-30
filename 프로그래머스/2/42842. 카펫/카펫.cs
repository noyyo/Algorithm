using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int width = 3;
        int height = 3;
        bool isRight = false;
        while (!isRight)
        {
            height = (brown + 4 - 2 * width) / 2;
            if (width * height == yellow + brown)
            {
                isRight = true;
            }
            else
            {
                width++;
            }
        }
        if (width < height)
        {
            int temp = width;
            width = height;
            height = temp;
        }
        int[] answer = new int[] { width, height };
        return answer;
    }
}