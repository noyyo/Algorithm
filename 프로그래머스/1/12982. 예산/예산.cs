using System;
using System.Linq;

public class Solution {
    public int solution(int[] d, int budget) {
        int[] orderedArray = d.OrderBy(request => request).ToArray();
        int sum = 0;
        int count = 0;
        for (int i = 0; i < orderedArray.Length; i++)
        {
            sum += orderedArray[i];
            if (sum <= budget)
                count++;
            else
                break;
        }
        return count;
    }
}