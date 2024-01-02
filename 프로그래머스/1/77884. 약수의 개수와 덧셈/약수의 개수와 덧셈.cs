using System;

public class Solution {
    public int solution(int left, int right) {
        int sum = 0;
        for (int i = left; i <= right; i++)
        {
            int count = 0;
            int j = 1;
            for (; j * j < i; j++)
            {
                if (i % j == 0)
                    count += 2;
            }
            if (j * j == i)
                count++;
            if (count % 2 == 0)
                sum += i;
            else
                sum -= i;
        }
        return sum;
    }
}