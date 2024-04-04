using System;
using System.Collections.Generic;

class Solution
{
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] sSplit = s.Split(" ");
        int n = int.Parse(sSplit[1]);
        int m = int.Parse(sSplit[0]);
        int[ , ] dist = new int[n, m];
        int[ , ] tomato = new int[n, m];
        Queue<(int x, int y)> que = new Queue<(int x, int y)>();
        int maxDist = 0;
        
        int[] dx = { 1, 0, -1, 0 };
        int[] dy = { 0, 1, 0, -1 };
        for (int i = 0; i < n; i++)
        {
            s = Console.ReadLine();
            sSplit = s.Split(" ");
            for (int j = 0; j < m; j++)
            {
                tomato[i, j] = int.Parse(sSplit[j]);
                if (tomato[i, j] == 1)
                {
                    que.Enqueue((i, j));
                    dist[i, j] = 0;
                }
                else
                    dist[i, j] = -1;
            }
        }
        
        while (que.Count > 0)
        {
            var point = que.Dequeue();
            if (dist[point.x, point.y] > maxDist)
                maxDist = dist[point.x, point.y];
            for (int dir = 0; dir < 4; dir++)
            {
                int nx = point.x + dx[dir];
                int ny = point.y + dy[dir];
                if (nx < 0 || nx >= n || ny < 0 || ny >= m)
                    continue;
                if (tomato[nx, ny] != 0)
                    continue;
                if (dist[nx, ny] != -1)
                    continue;
                dist[nx, ny] = dist[point.x, point.y] + 1;
                que.Enqueue((nx, ny));
            }
        }
        bool canRipe = true;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (canRipe && tomato[i, j] == 0 && dist[i, j] == -1)
                {
                    canRipe = false;
                    Console.WriteLine(-1);
                    break;
                }
        if (canRipe)
            Console.WriteLine(maxDist);
    }
}