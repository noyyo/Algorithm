using System;

public class Solution {
        public int solution(string[] babbling)
        {
            int answer = 0;
            string[] canBabbleWords = { "aya", "ye", "woo", "ma" };
            for (int i = 0; i < babbling.Length; i++)
            {
                string word = babbling[i];
                int checkStartIndex = 0;
                int lastBabbleWordIndex = -1;
                for (int j = 1; j < word.Length; j++)
                {
                    string compare = word.Substring(checkStartIndex, j - checkStartIndex + 1);
                    for (int k = 0; k < canBabbleWords.Length; k++)
                    {
                        if (compare == canBabbleWords[k] && lastBabbleWordIndex != k)
                        {
                            lastBabbleWordIndex = k;
                            checkStartIndex = j + 1;
                        }
                    }
                }
                if (checkStartIndex == word.Length)
                {
                    answer++;
                }
            }
            return answer;
        }
}