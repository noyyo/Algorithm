using System.Text;

public class Solution {
    public string solution(string s) {
        string[] words = s.Split(' ');
        StringBuilder answer = new StringBuilder();
        foreach (string word in words)
        {
            char[] str = word.Trim().ToUpper().ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 1)
                {
                    str[i] = (char)(str[i] + 32);
                }
            }
            answer.Append(new string(str) + " ");
        }
        answer.Remove(answer.Length - 1, 1);
        return answer.ToString();
    }
}