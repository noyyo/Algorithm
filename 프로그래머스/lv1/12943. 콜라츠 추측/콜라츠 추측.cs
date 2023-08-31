public class Solution {
    public int solution(long num) {
        int count = 0;
        while (count <= 500)
        {
            if (num % 2 == 0)
            {
                num /= 2;
                count++;
            }
            else if(num == 1)
            {
                return count;
            }
            else
            {
                num = num * 3 + 1;
                count++;
            }
        }

        return -1;
    }
}