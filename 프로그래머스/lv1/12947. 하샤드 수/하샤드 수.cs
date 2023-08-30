public class Solution {
    public bool solution(int x) {
        bool answer = false;
        int temp = x;
        int digitsSum = 0;
        while (x != 0)
        {
            digitsSum += x % 10;
            x /= 10;
        }
        x = temp;
        
        answer = x % digitsSum == 0 ? true:false;
        
        return answer;
    }
}