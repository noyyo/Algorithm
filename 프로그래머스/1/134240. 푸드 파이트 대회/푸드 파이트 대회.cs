using System;
using System.Text;

public class Solution {
    public string solution(int[] food) {
        StringBuilder left = new StringBuilder();
        StringBuilder right = new StringBuilder();
        for (int foodNumber = 1; foodNumber < food.Length; foodNumber++)
        {
            for (int i = 0 ; i < food[foodNumber] / 2; i++)
            {
                left.Append(foodNumber.ToString());
                right.Insert(0, foodNumber.ToString());
            }
        }
        left.Append("0");
        left.Append(right);
        return left.ToString();
    }
}