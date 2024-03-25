public class Solution {
    public string solution(string s) {
        string[] split = s.Split(" ");
        int min = int.MaxValue;
        int max = int.MinValue;
        for (int i = 0; i < split.Length; i++)
        {
            int number = int.Parse(split[i]);
            if (number < min)
                min = number;
            if (number > max)
                max = number;
        }
        return min + " " + max;
    }
}