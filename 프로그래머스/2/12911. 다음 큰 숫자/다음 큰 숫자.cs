using System;
using System.Text;

class Solution 
{
    public int solution(int n) 
   {
        StringBuilder sb = new StringBuilder();
        
        while (n != 0)
        {
            sb.Insert(0, n % 2);
            n /= 2;
        }
        int oneCount = 0;
        int index = 0;
        bool isOneFound = false;
        bool isFound = false;
        for (int i = sb.Length - 1; i >= 0; i--)
        {
            if (!isOneFound && sb[i] == '1')
            {
                isOneFound = true;
                oneCount++;
            }
            else if (sb[i] == '1')
                oneCount++;
            else if (isOneFound && sb[i] == '0')
            {
                index = i;
                isFound = true;
                break;
            }
        }
        if (isFound)
        {
            sb[index] = '1';
            for (int i = index + 1; i < sb.Length; i++)
            {
                sb[i] = '0';
            }
            for (int i = sb.Length - 1; i > sb.Length - 1 - (oneCount - 1); i--)
            {
                sb[i] = '1';
            }
        }
        else
        {
            sb.Replace('1', '0');
            sb.Insert(0, '1');
            for (int i = sb.Length - 1; i > sb.Length - 1 - (oneCount - 1); i--)
            {
                sb[i] = '1';
            }
        }
        
        int sum = 0;
        if (sb[sb.Length - 1] == '1')
            sum = 1;
        for (int i = sb.Length - 2; i >= 0; i--)
        {
            if (sb[i] == '1')
            {
                int result = 1;
                for (int exp = 1; exp <= sb.Length - 1 - i; exp++)
                {
                    result *= 2;
                }
                sum += result;
            }
        }
        return sum;
    }
}