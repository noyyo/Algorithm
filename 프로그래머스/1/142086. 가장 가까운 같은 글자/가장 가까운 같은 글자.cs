using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string s) {
        Dictionary<char, List<int>> spellingAndIndexPair = new Dictionary<char, List<int>>();
        int[] answer = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            if (spellingAndIndexPair.ContainsKey(s[i]))
            {
                List<int> indexList = spellingAndIndexPair[s[i]];
                answer[i] = i - indexList.Last();
                indexList.Add(i);
            }
            else
            {
                List<int> indexList = new List<int>();
                indexList.Add(i);
                spellingAndIndexPair.Add(s[i], indexList);
                answer[i] = -1;
            }
        }
        
        return answer;
    }
}