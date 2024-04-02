using System;
using System.Collections.Generic;

class Solution
{

    public int[] solution(int n, string[] words)
    {
        HashSet<string> alreadyCall = new HashSet<string>(words.Length);
        List<int> callNumbers = new List<int>(n);
        for (int i = 0; i < n; i++)
            callNumbers.Add(0);

        int personNum = 0;
        int callNum = 0;
        int batchNum = words.Length / n;
        if (words.Length % n > 0)
            batchNum++;
        bool isWrong = false;
        string lastStr = string.Empty;
        
        for (int i = 0; i < batchNum; i++)
        {
            if (isWrong)
                break;
            for (int j = 0; j < n; j++)
            {
                int currentIndex = i * n + j;
                if (currentIndex >= words.Length)
                    break;
                string currentStr = words[currentIndex];
                if (alreadyCall.Contains(currentStr))
                {
                    isWrong = true;
                    personNum = j + 1;
                    callNum = ++callNumbers[j];
                    break;
                }
                else if (currentIndex > 0 && lastStr[lastStr.Length - 1] != currentStr[0])
                {
                    isWrong = true;
                    personNum = j + 1;
                    callNum = ++callNumbers[j];
                    break;
                }
                else
                {
                    lastStr = currentStr;
                    alreadyCall.Add(currentStr);
                    callNumbers[j]++;
                }
            }
        }
        int[] answer = new int[] { personNum, callNum };
        
        return answer;
    }
}