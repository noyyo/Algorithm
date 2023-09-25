public class Solution {
    public int[] solution(int n, int m) {
        bool isEnd = false;
        int devidend = n;
        int devisor = m;
        int remainder = n % m;
        if (remainder == 0)
            isEnd = true;
        while (!isEnd)
        {
            devidend = devisor;
            devisor = remainder;
            remainder = devidend % devisor;
            if (remainder == 0)
                isEnd = true;
        }
        int greatestCommonDivison = devisor;
        int leastCommonMultiple = n * m / greatestCommonDivison;
        int[] answer = new int[2];
        answer[0] = greatestCommonDivison;
        answer[1] = leastCommonMultiple;
        return answer;
    }
}