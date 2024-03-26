using System.Text;

public class Solution {
    public string solution(string s) {
        
        StringBuilder sb = new StringBuilder(s.ToLower());
        bool isFirstAlphabet = true;
        for (int i = 0; i < sb.Length; i++)
        {
            if (isFirstAlphabet && sb[i] >= 'a' && sb[i] <= 'z')
            {
                sb[i] = (char)(sb[i] + 'A' - 'a');
                isFirstAlphabet = false;
            }
            else if (sb[i] == ' ')
                isFirstAlphabet = true;
            else if (sb[i] >= '0' && sb[i] <= '9')
                isFirstAlphabet = false;
        }
        return sb.ToString();
    }
}