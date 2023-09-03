using System;

public class Solution {
    public int solution(int[] numbers) {
        int sum = 0;
        bool[] isNum = new bool[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            isNum[numbers[i]] = true;
        }
        for (int i = 0; i < isNum.Length; i++)
        {
            if (!isNum[i])
                sum += i;
        }
        
        return sum;
    }
}