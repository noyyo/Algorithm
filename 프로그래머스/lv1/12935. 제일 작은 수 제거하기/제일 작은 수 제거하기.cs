public class Solution {
    public int[] solution(int[] arr) {
        int min = arr[0];
        
        foreach(int num in arr)
        {
            if (min > num)
                min = num;
        }
        int[] answer = new int[arr.Length - 1];
        // 최솟값을 가진 인덱스는 복사하지 않음
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == min)
                j--;
            else
                answer[j] = arr[i];
            j++;
        }
        if (answer.Length == 0)
            answer = new int[] {-1};
        return answer;
    }
}