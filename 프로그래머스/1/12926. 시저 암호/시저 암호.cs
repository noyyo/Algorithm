public class Solution {
    public string solution(string s, int n) {
        char[] charArray = s.ToCharArray();
        
        for (int i = 0; i < charArray.Length; i++)
        {
            if (charArray[i] != ' ')
            {
                char c = (char)(charArray[i] + n);
                if (c > 'z')
                    c = (char)('a' + (c % ('z' + 1)));
                else if (c > 'Z' && charArray[i] <= 'Z')
                    c = (char)('A' + (c % ('Z' + 1)));
                charArray[i] = c;
            }
        }
        string answer = new string(charArray);
        return answer;
    }
}