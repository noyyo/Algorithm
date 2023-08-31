public class Solution {
    public string solution(string[] seoul) {
        const string kim = "Kim";
        for (int i = 0; i < seoul.Length; i++)
        {
            if (seoul[i] == kim)
            {
                return $"김서방은 {i}에 있다";
            }
        }
        return "";
    }
}