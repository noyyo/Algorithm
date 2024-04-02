using System;
public class Solution {
    public int solution(int[] arr) {
        int currentLCM = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            currentLCM = Math.Abs(currentLCM * arr[i]) / GetGCD(currentLCM, arr[i]);
        }
        return currentLCM;
    }
    private int GetGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}