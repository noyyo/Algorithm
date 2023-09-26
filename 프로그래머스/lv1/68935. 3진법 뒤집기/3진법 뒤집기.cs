using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        List<int> rest = new List<int>();
        while (n != 0)
        {
            rest.Add(n % 3);
            n /= 3;
        }
        rest.Reverse();
        int answer = 0;
        for (int i = 0; i < rest.Count; i++)
        {
            answer += (int)(rest[i] * Math.Pow(3, i));
        }
        return answer;
    }
}