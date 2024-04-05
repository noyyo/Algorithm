using System;
using System.Collections.Generic;

class Solution
{
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] sSplit = s.Split(" ");
        int n = int.Parse(sSplit[0]);
        int k = int.Parse(sSplit[1]);
        int[] dist = new int[100001];
        Array.Fill(dist, -1);
        dist[n] = 0;
        Queue<int> que = new Queue<int>();
        que.Enqueue(n);
        
        while (que.Count > 0)
        {
            int current = que.Dequeue();
            if (current == k)
            {
                Console.Write(dist[current]);
                break;
            }
            for (int dir = 0; dir < 3; dir++)
            {
                int next = dir switch
                {
                    0 => current - 1,
                    1 => current + 1,
                    2 => current * 2,
                };
                if (next < 0 || next > 100000)
                    continue;
                if (dist[next] != -1)
                    continue;
                dist[next] = dist[current] + 1;
                que.Enqueue(next);
            }
        }
    }
}