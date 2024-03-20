using System;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int[] haveOutfit = new int[n];
        for (int i = 0; i < n; i++)
        {
            haveOutfit[i] = 1;
        }
        for (int i = 0; i < lost.Length; i++)
        {
            haveOutfit[lost[i] - 1]--;
        }
        for (int i = 0; i < reserve.Length; i++)
        {
            haveOutfit[reserve[i] - 1]++;
        }
        for (int i = 0; i < n; i++)
        {
            if(haveOutfit[i] == 0 && i > 0 && haveOutfit[i - 1] == 2)
            {
                haveOutfit[i - 1] = 1;
                haveOutfit[i] = 1;
            }
            else if(haveOutfit[i] == 0 && i < n - 1 && haveOutfit[i + 1] == 2)
            {
                haveOutfit[i + 1] = 1;
                haveOutfit[i] = 1;
            }
        }
        
        int answer = 0;
        for (int i = 0; i < n; i++)
        {
            if(haveOutfit[i] >= 1)
                answer++;
        }
        return answer;
    }
}