using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int maxDigit = 100000000 / 3 + 1;
        int[] base3 = new int[maxDigit];
        int i = 0;
        while (n != 0)
        {
            base3[i] = n % 3;
            n = n / 3;
            i++;
        }
        int answer = 0;
        for (int j = 0; j <= i; j++)
        {
            answer += base3[j] * (int)Math.Pow(3, (i - 1) - j);
        }
        return answer;
    }
}