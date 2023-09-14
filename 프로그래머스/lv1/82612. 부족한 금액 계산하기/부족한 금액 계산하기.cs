using System;

class Solution
{
    public long solution(int price, long money, int count)
    {
        long sum = 0;
        for (int i = 0; i < count; i++)
        {
            sum += price * (i + 1);
        }
        if (money >= sum)
            return 0;
        return sum - money;
    }
}