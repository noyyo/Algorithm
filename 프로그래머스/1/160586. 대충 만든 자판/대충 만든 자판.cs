using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        Dictionary<char, int> minimumPress = new Dictionary<char, int>(30);
            for (char c = 'A'; c <= 'Z'; c++)
            {
                minimumPress.Add(c, -1);
            }
        
        for (int i = 0; i < keymap.Length; i++)
        {
            string key = keymap[i];
            for (int j = 0; j < key.Length; j++)
            {
                char c = key[j];
                if (minimumPress[c] < 0)
                    minimumPress[c] = j + 1;
                else if (j + 1 < minimumPress[c])
                    minimumPress[c] = j + 1;
            }
        }
        int[] answer = new int[targets.Length];
        
        for (int i = 0; i < targets.Length; i++)
        {
            string target = targets[i];
            int pressCount = 0;
            bool canMake = true;
            for (int j = 0; j < target.Length; j++)
            {
                if (minimumPress[target[j]] < 0)
                {
                    canMake = false;
                    pressCount = -1;
                }
                if (canMake)
                    pressCount += minimumPress[target[j]];
                else
                    break;
            }
            answer[i] = pressCount;
        }
        
        return answer;
    }
}