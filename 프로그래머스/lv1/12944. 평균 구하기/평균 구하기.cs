public class Solution {
    public double solution(int[] arr) {
        int sum = 0;
        foreach (int i in arr)
            sum += i;
        
        return (double)sum / arr.Length;
    }
}