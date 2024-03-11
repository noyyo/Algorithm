public class Solution {
    public int solution(int n) {
        bool[] eratos = new bool[n + 1];
        for (int i = 2; i < eratos.Length; i++)
        {
            eratos[i] = true;
        }
        for (int i = 2; i * i <= n; i++)
        {
            if (eratos[i] == true)
            {
                for (int j = i * i; j <= n; j += i)
                {
                    eratos[j] = false;
                }
            }
        }
        int count = 0;
        for (int i = 2; i <= n; i++)
        {
            if (eratos[i] == true)
                count++;
        }
        
        return count;
    }
}