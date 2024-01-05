using System;

public class Solution {
    public int solution(string[] want, int[] number, string[] discount) {
        int answer = 0;
        int[] discountNumber = new int[number.Length];
        bool canSignUp;
        for (int i = 0; i < discount.Length; i++)
        {
            for (int j = 0; j < want.Length; j++)
            {
                if (want[j] == discount[i])
                {
                    discountNumber[j]++;
                }
                if (i >= 10 && want[j] == discount[i - 10])
                {
                    discountNumber[j]--;
                }
            }
            canSignUp = true;
            for (int k = 0; k < number.Length; k++)
            {
                if (number[k] != discountNumber[k])
                {
                    canSignUp = false;
                    break;
                }    
            }
            if (canSignUp)
                answer++;
        }

        return answer;
    }
}