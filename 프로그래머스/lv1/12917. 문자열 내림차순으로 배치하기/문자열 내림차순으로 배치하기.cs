using System.Linq;

public class Solution {
    public string solution(string s) {
        char[] charArray = s.ToCharArray();
        string answer = new string(charArray.OrderByDescending(ch => ch).ToArray());
        
        return answer;
    }
}