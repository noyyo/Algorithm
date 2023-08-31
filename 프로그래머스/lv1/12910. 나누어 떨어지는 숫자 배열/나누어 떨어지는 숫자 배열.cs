using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr, int divisor) {
        List<int> answerList = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % divisor == 0)
            {
                if (!answerList.Contains(arr[i]))
                    answerList.Add(arr[i]);
            }
        }
        int[] answer;
        if (answerList.Count == 0)
        {
            answer = new int [] {-1};
            return answer;            
        }
        answerList = answerList.OrderBy(item => item).ToList();
        answer = answerList.ToArray();
        return answer;
    }
}