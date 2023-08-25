public class Solution {
    public string solution(int num) {
        bool isEven = false;
        if (num % 2 == 0)
            isEven = true;
        else
            isEven = false;
        
        string answer = "";
        if (isEven)
        {
            answer = "Even";
        }
        else
        {
            answer = "Odd";
        }
        return answer;
    }
}