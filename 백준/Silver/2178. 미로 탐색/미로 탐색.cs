using System;
using System.Collections.Generic;

class Solution
{
    public static void Main()
    {
        string s = Console.ReadLine()!;
        string[] sSplit = s.Split(" ");
        int n = int.Parse(sSplit[0]);
        int m = int.Parse(sSplit[1]);
        
        string[] maze = new string[n];
        int[ , ] dist = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            maze[i] = Console.ReadLine()!;
        }
        
        int[] dx = { 1, 0, -1, 0 };
        int[] dy = { 0, 1, 0, -1 };
        Queue<(int x, int y)> que = new Queue<(int x, int y)>();
        que.Enqueue((0, 0));
        while (que.Count > 0)
        {
            var point = que.Dequeue();
            for (int dir = 0; dir < 4; dir++)
            {
                int nx = point.x + dx[dir];
                int ny = point.y + dy[dir];
                
                if (nx < 0 || nx >= n || ny < 0 || ny >= m)
                    continue;
                if (dist[nx, ny] != 0)
                    continue;
                if (maze[nx][ny] == '1')
                {
                    dist[nx, ny] = dist[point.x, point.y] + 1;
                    que.Enqueue((nx, ny));
                }
                else
                    dist[nx, ny] = -1;
            }
        }
        Console.WriteLine(dist[n - 1, m - 1] + 1);
        
    }
}