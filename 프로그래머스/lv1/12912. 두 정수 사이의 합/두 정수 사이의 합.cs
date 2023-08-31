public class Solution {
    public long solution(int a, int b) {
        bool aIsBigger = false;
        int smallNum;
        int bigNum;
        aIsBigger = a > b? true : false;
        if (aIsBigger)
        {
            bigNum = a;
            smallNum = b;
        }
        else
        {
            bigNum = b;
            smallNum = a;
        }
        
        long answer = 0;
        
        for (; smallNum <= bigNum; smallNum++)
        {
            answer += smallNum;
        }
        return answer;
    }
}