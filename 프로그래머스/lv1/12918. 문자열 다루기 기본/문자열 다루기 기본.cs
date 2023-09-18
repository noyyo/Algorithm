public class Solution {
    public bool solution(string s) {
        bool answer = true;
        if (s.Length != 4 && s.Length != 6)
            return false;
        for (int i = 0 ; i < s.Length; i++)
        {
            char ch = s[i];
            if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
                answer = false;
        }
        return answer;
    }
}