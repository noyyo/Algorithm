using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        string[] numberString = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        for (int i = 0; i < numberString.Length; i++)
        {
            s = s.Replace(numberString[i], i.ToString());
        }
        int answer = int.Parse(s);
        
        return answer;
    }
}