using System;
using System.Text;
using System.Linq;

public class Solution {
    public string solution(string X, string Y)
    {
        int[] numCountX = new int[10];
        int[] numCountY = new int[10];
        CountNumber(X, numCountX);
        CountNumber(Y, numCountY);
        StringBuilder sb = new StringBuilder();
        for (int i = 9; i >= 0; i--)
        {
            int CoupleCount = Math.Min(numCountX[i], numCountY[i]);
            for (int j = 0; j < CoupleCount; j++)
            {
                sb.Append(i.ToString());
            }
        }
        string answer = sb.ToString();
        if (answer.Length < 1)
            answer = "-1";
        else if (answer[0] == '0')
            answer = "0";
        return answer;
    }
    private void CountNumber(string input, int[] countArray)
    {
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            switch (c)
            {
                case '0': countArray[0]++;
                    break;
                case '1': countArray[1]++;
                    break;
                case '2': countArray[2]++;
                    break;
                case '3': countArray[3]++;
                    break;
                case '4': countArray[4]++;
                    break;
                case '5': countArray[5]++;
                    break;
                case '6': countArray[6]++;
                    break;
                case '7': countArray[7]++;
                    break;
                case '8': countArray[8]++;
                    break;
                case '9': countArray[9]++;
                    break;
            }
        }
    }
}