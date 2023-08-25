using System;
public class Solution {
    public long solution(long n) {
        int x = (int)Math.Sqrt(n);
        return Math.Pow(x, 2) == n ? (long)Math.Pow(x + 1, 2) : -1;
    }
}