public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        string backNumber = phone_number.Substring(phone_number.Length - 4, 4);
        for (int i = 0; i < phone_number.Length - 4;i++)
        {
            answer += "*";
        }
        answer += backNumber;
        return answer;
    }
}