using System.Collections.Generic;
using System.Linq;

public class Solution {
    public long solution(long n) {
        
        // 자릿수를 분리한다
        int num = 0;
        List<int> digits = new List<int>();
        while (n != 0)
        {
            num = (int)(n % 10);
            digits.Add(num);
            n /= 10;
        }
        // 분리한 자릿수를 정렬한다
        digits = digits.OrderByDescending(item => item).ToList();
        
        // 곱해서 새로운 정수를 만든다
        long answer = 0;
            
        for (int i = 0; i < digits.Count; i++)
        {
            answer *= 10;
            answer += digits[i];
        }
        
        return answer;
    }
}