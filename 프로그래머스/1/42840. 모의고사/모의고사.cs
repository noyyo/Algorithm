using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        List<int> pattern1 = new List<int>() { 1, 2, 3, 4, 5 };
        List<int> pattern2 = new List<int>() { 2, 1, 2, 3, 2, 4, 2, 5 };
        List<int> pattern3 = new List<int>() { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
        List<int> correct = new List<int>() { 0, 0, 0 };

        for (int i = 0; i < answers.Length; i++)
        {
            if (pattern1[i % pattern1.Count] == answers[i])
                correct[0]++;
            if (pattern2[i % pattern2.Count] == answers[i])
                correct[1]++;
            if (pattern3[i % pattern3.Count] == answers[i])
                correct[2]++;
        }
        
        List<int> bestMember = new List<int>();
        int bestScore = 0;
        for (int i = 0; i < correct.Count; i++)
        {
            if (bestScore < correct[i])
                bestScore = correct[i];
        }
        for (int i = 0; i < correct.Count; i++)
        {
            if (correct[i] == bestScore)
                bestMember.Add(i + 1);
        }
            
        
        return bestMember.ToArray();
    }
}