using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int[] kScore = new int[k];
        for (int i = 0; i < score.Length; i++)
        {
            kScore[score[i] - 1]++;
        }
        int sum = 0;
        int rest = 0;
        for (int j = kScore.Length - 1; j >= 0; j--)
        {
            int count = kScore[j] + rest;
            sum += count / m * (j + 1) * m;
            rest = count % m;
        }

        return sum;
    }
}