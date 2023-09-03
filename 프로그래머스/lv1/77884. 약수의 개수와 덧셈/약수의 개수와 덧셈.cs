using System;
using System.Collections.Generic;

public class Solution {
    private List<int>primeNumbers;
    private int naturalNumberInput;
    public Solution()
    {
        naturalNumberInput = 1000;
        Init();
    }
    public int solution(int left, int right) {
        int sum = 0;
        for (int i = left; i <= right; i++)
        {
            if (GetDivisorCount(i) % 2 == 0)
                sum += i;
            else
                sum -= i;
        }
        
        return sum;
    }
    public int GetDivisorCount(int naturalNumber)
    {
        List<int> primeDivisorsPowerCount = new List<int>();
        for (int i = 0; i < primeNumbers.Count; i++)
        {
            if (primeNumbers[i] > naturalNumber)
                break;
            int primeNumPowerCount = 0;
            int calcNum = naturalNumber;
            while (calcNum >= primeNumbers[i] && calcNum % primeNumbers[i] == 0)
            {
                calcNum /= primeNumbers[i];
                primeNumPowerCount++;
            }
            if (primeNumPowerCount > 0)
                primeDivisorsPowerCount.Add(primeNumPowerCount);
            primeNumPowerCount = 0;
        }
        
        int divisorCount = 1;
        foreach(int powerCount in primeDivisorsPowerCount)
        {
            divisorCount *= (powerCount + 1);
        }
        return divisorCount;
    }
    private void Init()
    {
        primeNumbers = new List<int>();
        bool[] isPrime = new bool[naturalNumberInput + 1];
        for (int i = 2; i <= naturalNumberInput; i++)
            isPrime[i] = true;
        for (int num = 2; num * num <= naturalNumberInput; num++)
        {
            if (isPrime[num])
            {
                for (int multiple = num * num; multiple < naturalNumberInput; multiple += num)
                {
                    isPrime[multiple] = false;
                }
            }
        }
        for (int num = 2; num <= naturalNumberInput; num++)
        {
            if (isPrime[num])
                primeNumbers.Add(num);
        }
    }
}