using System;
using System.Collections.Generic;

class Solution
{
    public static void Main()
    {
        string s = Console.ReadLine()!;
        string[] sSplit = s.Split(" ");
        int r = int.Parse(sSplit[0]);
        int c = int.Parse(sSplit[1]);
        int[ , ] maze = new int[r, c];
        Queue<(int x, int y)> playerQueue = new Queue<(int x, int y)>();
        Queue<(int x, int y)> fireQueue = new Queue<(int x, int y)>();
        int[ , ] dist = new int[r, c];
        for (int i = 0; i < r; i++)
        {
            s = Console.ReadLine()!;
            for (int j = 0; j < c; j++)
            {
                dist[i, j] = -1;
                if (s[j] == '#')
                    maze[i, j] = -1;
                else if (s[j] == '.')
                    maze[i, j] = 0;
                else if (s[j] == 'J')
                {
                    maze[i, j] = 0;
                    playerQueue.Enqueue((i, j));
                    dist[i, j] = 0;
                }
                else if (s[j] == 'F')
                {
                    maze[i, j] = 1;
                    fireQueue.Enqueue((i, j));
                }
            }
        }
        int[] dx = { 1, 0, -1, 0 };
        int[] dy = { 0, 1, 0, -1 };
        int maxDist = 0;
        while (playerQueue.Count > 0)
        {
            int curFireCount = fireQueue.Count;
            for (int i = 0; i < curFireCount; i++)
            {
                var point = fireQueue.Dequeue();
                for (int dir = 0; dir < 4; dir++)
                {
                    int nx = point.x + dx[dir];
                    int ny = point.y + dy[dir];
                    if (nx < 0 || nx >= r || ny < 0 || ny >= c)
                        continue;
                    if (maze[nx, ny] == -1)
                        continue;
                    if (maze[nx, ny] == 1)
                        continue;
                    maze[nx, ny] = 1;
                    fireQueue.Enqueue((nx, ny));
                }
            }
            int curPlayerCount = playerQueue.Count;
            for (int i = 0; i < curPlayerCount; i++)
            {
                var point = playerQueue.Dequeue();
                if (dist[point.x, point.y] > maxDist)
                    maxDist = dist[point.x, point.y];
                if (point.x == 0 || point.x == r - 1 || point.y == 0 || point.y == c - 1)
                {
                    Console.WriteLine(maxDist + 1);
                    return;
                }
                for (int dir = 0; dir < 4; dir++)
                {
                    int nx = point.x + dx[dir];
                    int ny = point.y + dy[dir];
                    if (nx < 0 || nx >= r || ny < 0 || ny >= c)
                        continue;
                    if (maze[nx, ny] == -1)
                        continue;
                    if (maze[nx, ny] == 1)
                        continue;
                    if (dist[nx, ny] != -1)
                        continue;
                    dist[nx, ny] = dist[point.x, point.y] + 1;

                    playerQueue.Enqueue((nx, ny));
                }
            }
        }
        Console.WriteLine("IMPOSSIBLE");
    }
}