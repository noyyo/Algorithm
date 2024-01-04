using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] ingredient) {
        int index = 0;
        List<int> iList = ingredient.ToList();
        int[] order = { 1, 2, 3, 1 };
        bool isRightOrder;
        int makedBurger = 0;
        while (index < iList.Count - (order.Length - 1))
        {
            isRightOrder = true;
            for (int i = 0; i < order.Length; i++)
            {
                if (iList[index + i] != order[i])
                {
                    isRightOrder = false;
                    break;
                }
            }
            if (isRightOrder)
            {
                iList.RemoveRange(index, order.Length);
                index -= order.Length;
                makedBurger++;
            }
            index++;
            if (index < 0)
                index = 0;
        }
        return makedBurger;
    }
}