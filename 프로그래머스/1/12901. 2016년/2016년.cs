using System.Collections.Generic;    

public class Solution
    {
        public string solution(int a, int b)
        {
            List<string> dayOfWeek = new List<string>() { "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN" };
            List<int> daysOfMonth = new List<int>() { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int days = 0;
            for (int i = 0; i < a - 1; i++)
            {
                days += daysOfMonth[i];
            }
            days += b - 1;
            string answer = dayOfWeek[(days + 4) % 7];
            
            return answer;
        }
    }