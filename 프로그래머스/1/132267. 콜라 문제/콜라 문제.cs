using System;

public class Solution {
    public int solution(int a, int b, int n) {
        // 가지고 있는 콜라 개수가 교환할 수 있는 콜라 수보다 많다면 반복
        int exchangeCount;
        int sum = 0;
        while (n >= a)
        {
            exchangeCount = n / a;
            n -= exchangeCount * a;
            n += exchangeCount * b;
            sum += exchangeCount * b;
        }
        
        return sum;
    }
}