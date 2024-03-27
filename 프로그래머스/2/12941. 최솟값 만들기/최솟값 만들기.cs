using System;
using System.Linq;

public class Solution {
    public int solution(int[] A, int[] B) {
        A = A.OrderBy(x => x).ToArray();
        B = B.OrderBy(x => x).ToArray();
        int sum = 0;
        for (int i = 0; i < A.Length; i++)
        {
            sum += A[i] * B[B.Length -1 - i];
        }
        
        return sum;
    }
}