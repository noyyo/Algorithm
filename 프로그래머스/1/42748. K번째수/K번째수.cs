using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        List<int> answer = new List<int>();
        
        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int first = commands[i, 0];
            int second = commands[i, 1];
            int third = commands[i, 2];
            int[] temp = new int[second - first + 1];
            for (int j = 0; j < temp.Length; j++)
            {
                temp[j] = array[first - 1 + j];
            }
            temp = temp.OrderBy(x => x).ToArray();
            answer.Add(temp[third - 1]);
        }
        return answer.ToArray();
    }
}