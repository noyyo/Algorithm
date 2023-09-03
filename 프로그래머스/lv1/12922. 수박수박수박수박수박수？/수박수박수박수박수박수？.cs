using System.Text;

public class Solution {
    public string solution(int n) {
        string repeatString = "수박";
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < n / 2; i++)
            stringBuilder.Append(repeatString);
        stringBuilder.Append(repeatString.Substring(0, n % 2));
        string answer = stringBuilder.ToString();
        return answer;
    }
}