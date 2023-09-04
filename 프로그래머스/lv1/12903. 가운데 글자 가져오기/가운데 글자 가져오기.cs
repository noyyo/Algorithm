public class Solution {
    public string solution(string s) {
        int halfIndex = s.Length / 2;
        string answer = "";
        
        if (s.Length % 2 == 0)
            answer = s.Substring(halfIndex - 1, 2);
        else
            answer = s.Substring(halfIndex, 1);
        
        return answer;
    }
}