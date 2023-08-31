using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        int sum = 0;
        int num = 0;
        for (int i = 0; i < absolutes.Length; i++)
        {
            num = signs[i]? absolutes[i] : -absolutes[i];
            sum += num;
        }
        
        return sum;
    }
}