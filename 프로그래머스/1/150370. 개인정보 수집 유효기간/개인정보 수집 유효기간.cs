using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        int todayYear;
        int todayMonth;
        int todayDay;
        DateStringToInt(today, out todayYear, out todayMonth, out todayDay);
        
        Dictionary<string, int> termsDic = new Dictionary<string, int>();
        for (int i = 0; i < terms.Length; i++)
        {
            string[] termsSplit = terms[i].Split(" ");
            string term = termsSplit[0];
            int expiration = int.Parse(termsSplit[1]) * 28;
            termsDic.Add(term, expiration);
        }
        List<int> expiredPrivacy = new List<int>();
        for (int i = 0; i < privacies.Length; i++)
        {
            int year;
            int month;
            int day;
            string[] split = privacies[i].Split(" ");
            DateStringToInt(split[0], out year, out month, out day);
            int elapsed = (todayYear - year) * 12 * 28 + (todayMonth - month) * 28 + (todayDay - day);
            if (elapsed >= termsDic[split[1]])
            {
                expiredPrivacy.Add(i + 1);
            }
        }
        
        return expiredPrivacy.ToArray();;
    }
    private void DateStringToInt(string date, out int year, out int month, out int day)
    {
        string[] split = date.Split(".");
        year = int.Parse(split[0]);
        month = int.Parse(split[1]);
        day = int.Parse(split[2]);
    }
}