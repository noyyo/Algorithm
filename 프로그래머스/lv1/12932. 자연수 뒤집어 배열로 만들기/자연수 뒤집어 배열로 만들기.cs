public class Solution {
    public int[] solution(long n) {
        int[] answer;
        int digit = 0;
        int count = 0;
        long temp = n; 
        while (n != 0)
        {
            n /= 10;
            count++;
        }
        n = temp;
        answer = new int[count];
        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = (int)(n % 10);
            n /= 10;
        }
        
        return answer;
    }
}