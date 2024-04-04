using System;
using System.Collections.Generic;

class Solution
{
    public static void Main()
    {
        int row;
        int column;
        string s = Console.ReadLine()!;
        string[] sSplit = s.Split(" ");
        row = int.Parse(sSplit[0]);
        column = int.Parse(sSplit[1]);
        
        bool[ , ] picture = new bool[row, column];
        for (int i = 0; i < row; i++)
        {
            s = Console.ReadLine()!;
            for (int j = 0; j < column; j++)
            {
                if (s[j * 2] == '0')
                    picture[i, j] = false;
                else
                    picture[i, j] = true;
            }
        }
        
        bool[ , ] visited = new bool[row, column];
        Queue<(int row, int column)> que = new Queue<(int row, int column)>();
        int maxArea = 0;
        int pictureCount = 0;
        int[] dx = { 1, 0, -1, 0 };
        int[] dy = { 0, 1, 0, -1 };
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                if (visited[i, j])
                    continue;
                if (!picture[i, j])
                    continue;
                visited[i, j] = true;
                que.Enqueue((i, j));
                int area = 1;
                pictureCount++;
                while (que.Count > 0)
                {
                    var cord = que.Dequeue();
                    for (int dir = 0; dir < 4; dir++)
                    {
                        int nx = cord.row + dx[dir];
                        int ny = cord.column + dy[dir];
                        if (nx < i || nx >= row || ny < 0 || ny >= column)
                            continue;
                        if (visited[nx, ny])
                            continue;
                        visited[nx, ny] = true;
                        if (picture[nx, ny] == true)
                        {
                            area++;
                            que.Enqueue((nx, ny));
                        }
                    }
                }
                if (area > maxArea)
                    maxArea = area;
            }
        }
        Console.WriteLine(pictureCount);
        Console.WriteLine(maxArea);
    }
}