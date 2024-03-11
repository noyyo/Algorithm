using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int number, int limit, int power) {
        int[] divisorNumbers = new int[number];
        for (int i = 0; i < number; i++)
        {
            double sqr = Math.Sqrt(i + 1);
            for (int j = 1; j <= sqr; j++)
            {
                if ((i + 1) % j == 0 && j != sqr)
                    divisorNumbers[i] += 2;
                else if (j == sqr)
                    divisorNumbers[i] ++;
            }
        }
        int sum = 0;
        for (int i = 0; i < number; i++)
        {
            if (divisorNumbers[i] > limit)
                divisorNumbers[i] = power;
            sum += divisorNumbers[i];
        }

        return sum;
    }
}