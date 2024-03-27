using System;
using System.Text;

public class Solution {
    public int[] solution(string s) {
        StringBuilder sb = new StringBuilder(s);
        int zeroCount = 0;
        int conversionCount = 0;
        while (sb.ToString() != "1")
        {
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == '0')
                {
                    zeroCount++;
                    sb.Remove(i, 1);
                    i--;
                }
            }
            int Length = sb.Length;
            sb.Clear();
            while (Length != 0)
            {
                sb.Append(Length % 2);
                Length /= 2;
            }
            conversionCount++;
        }
        int[] answer = new int[] { conversionCount, zeroCount };
        return answer;
    }
}