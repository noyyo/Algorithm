using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] strings, int n) {
        Dictionary<char, List<string>> keys = new Dictionary<char, List<string>>();
        
        char ch = (char)0;
        for (int i = 0; i < strings.Length;i++)
        {
            ch = strings[i][n];
            if (!keys.ContainsKey(ch))
            {
                keys.Add(ch, new List<string>());
            }
            keys[ch].Add(strings[i]);
        }
        keys = keys.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        List<char> keyList = keys.Keys.ToList();
        for (int i = 0; i < keyList.Count; i++)
        {
            keys[keyList[i]] = keys[keyList[i]].OrderBy(x => x).ToList();
        }
        List<string> answerList = new List<string>();
        foreach (char key in keys.Keys)
        {
            answerList.AddRange(keys[key]);
        }
        return  answerList.ToArray();
    }
}