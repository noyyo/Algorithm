using System;
using System.Collections.Generic;

class Solution
{
    public int solution(int[] nums)
    {
        int[] maxValues = new int[3];
        for (int i = 0; i < nums.Length; i++)
        {
            if (maxValues[0] < nums[i])
            {
                int temp = maxValues[0];
                maxValues[0] = nums[i];
                maxValues[2] = maxValues[1];
                maxValues[1] = temp;
            }
            else if (maxValues[1] < nums[i])
            {
                maxValues[2] = maxValues[1];
                maxValues[1] = nums[i];
            }
            else if (maxValues[2] < nums[i])
                maxValues[2] = nums[i];
        }
        int maxSum = maxValues[0] + maxValues[1] + maxValues[2];

        bool[] eratos = new bool[maxSum + 1];
        for (int i = 2; i < eratos.Length; i++)
        {
            eratos[i] = true;
        }
        for (int i = 2; i * i <= maxSum; i++)
        {
            if (eratos[i] == true)
            {
                for (int j = i * i; j <= maxSum; j += i)
                {
                    eratos[j] = false;
                }
            }
        }

        int primeCount = 0;
        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (eratos[sum] == true)
                        primeCount++;
                }
            }
        }

        return primeCount;
    }
}