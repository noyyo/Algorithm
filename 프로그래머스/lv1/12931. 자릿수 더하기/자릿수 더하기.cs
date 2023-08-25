using System;

public class Solution {
    public int solution(int n) {
        int digit = 0;
        int answer = 0;
        
        while (n != 0)
        {
            digit  = n % 10;
            answer += digit;
            n /= 10;
        }
        return answer;
    }
}