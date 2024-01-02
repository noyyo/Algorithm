using System.Text;

public class Solution {
    public string solution(string s) {
        StringBuilder sb = new StringBuilder(s);
        for (int i = 1; i < sb.Length; i++)
        {
            int j = i;
            char remember = sb[j];
            while (--j >= 0 && remember > sb[j])
            {
                sb[j + 1] = sb[j];
            }
            sb[j + 1] = remember;
        }
        return sb.ToString();
    }
}