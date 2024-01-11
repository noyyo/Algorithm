using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string category = "RTCFJMAN";
        Dictionary<char, int> scores = new Dictionary<char, int>();
        for (int i = 0; i < category.Length; i++)
        {
            scores.Add(category[i], 0);
        }
        for (int i = 0; i < survey.Length; i++)
        {
            if (choices[i] < 4)
            {
                scores[survey[i][0]] += 4 - choices[i];
            }
            else
            {
                scores[survey[i][1]] += choices[i] - 4;
            }
        }
        
        StringBuilder sb = new StringBuilder();
        for (int j = 0; j < category.Length; j += 2)
        {
            if (scores[category[j]] > scores[category[j + 1]])
            {
                sb.Append(category[j]);
            }
            else if (scores[category[j]] < scores[category[j + 1]])
            {
                sb.Append(category[j + 1]);
            }
            else
            {
                if (category[j] <= category[j + 1])
                {
                    sb.Append(category[j]);
                }
                else
                {
                    sb.Append(category[j + 1]);
                }
            }
        }
        return sb.ToString();
    }
}