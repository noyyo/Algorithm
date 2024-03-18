using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int zeroCount = 0;
        List<int> notZeroIndex = new List<int>(lottos.Length);
        for (int i = 0; i < lottos.Length; i++)
        {
            if (lottos[i] == 0)
            {
                zeroCount++;
            }
            else
            {
                notZeroIndex.Add(i);
            }
        }
        
        int winNumCount = 0;
        for (int i = 0; i < win_nums.Length; i++)
        {
            for (int j = 0; j < notZeroIndex.Count; j++)
            {
                if (win_nums[i] == lottos[notZeroIndex[j]])
                {
                    winNumCount++;
                }
            }
        }
        int resultWorst = 7 - winNumCount;
        if (resultWorst > 6)
            resultWorst = 6;
        int resultBest = 7 - winNumCount - zeroCount;
        if (resultBest < 1)
            resultBest = 1;
        else if (resultBest > 6)
            resultBest = 6;
        
        
        int[] answer = new int[] { resultBest, resultWorst };
        return answer;
    }
}