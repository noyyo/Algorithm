using System;

class Solution
{
    int n;
    int m;
    int cctv = 0;
    int[ , ] map;
    (int x, int y)[] cctvPos = new (int x, int y)[8];
    int[] dir = new int[8];
    int minArea = int.MaxValue;
    public Solution()
    {
        string s = Console.ReadLine();
        string[] sSplit = s.Split(" ");
        n = int.Parse(sSplit[0]);
        m = int.Parse(sSplit[1]);
        map = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            s = Console.ReadLine();
            sSplit = s.Split(" ");
            for (int j = 0; j < m; j++)
            {
                map[i, j] = int.Parse(sSplit[j]);
                if (map[i, j] > 0 && map[i, j] < 6)
                {
                    cctvPos[cctv] = (i, j);
                    cctv++;
                }
            }
        }
    }
    public static void Main()
    {
        Solution sol = new Solution();
        sol.Back(0);
        Console.Write(sol.minArea);
    }
    private void Back(int k)
    {
        (int x, int y) point;
        if (k == cctv)
        {
            for (int i = 0; i < cctv; i++)
            {
                point = cctvPos[i];
                if ((dir[i] & 0b0001) == 0b0001)
                    for (int j = point.x - 1; j >= 0; j--)
                    {
                        if (map[j, point.y] == 6)
                            break;
                        if (map[j, point.y] != 0)
                            continue;
                        map[j, point.y] = 7;
                    }
                if ((dir[i] & 0b0010) == 0b0010)
                    for (int j = point.x + 1; j < n; j++)
                    {
                        if (map[j, point.y] == 6)
                            break;
                        if (map[j, point.y] != 0)
                            continue;
                        map[j, point.y] = 7;
                    }
                if ((dir[i] & 0b0100) == 0b0100)
                    for (int j = point.y - 1; j >= 0; j--)
                    {
                        if (map[point.x, j] == 6)
                            break;
                        if (map[point.x, j] != 0)
                            continue;
                        map[point.x, j] = 7;
                    }
                if ((dir[i] & 0b1000) == 0b1000)
                    for (int j = point.y + 1; j < m; j++)
                    {
                        if (map[point.x, j] == 6)
                            break;
                        if (map[point.x, j] != 0)
                            continue;
                        map[point.x, j] = 7;
                    }
            }
            int sum = n * m;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (map[i, j] != 0)
                    {
                        sum--;
                        if (map[i, j] == 7)
                            map[i, j] = 0;
                    }
            if (sum < minArea)
                minArea = sum;
            return;
        }
        point = cctvPos[k];
        switch (map[point.x, point.y])
        {
            case 1 :
                dir[k] = 0b0001;
                Back(k + 1);
                dir[k] = 0b0010;
                Back(k + 1);
                dir[k] = 0b0100;
                Back(k + 1);
                dir[k] = 0b1000;
                Back(k + 1);
                break;
            case 2 :
                dir[k] = 0b0011;
                Back(k + 1);
                dir[k] = 0b1100;
                Back(k + 1);
                break;
            case 3 :
                dir[k] = 0b1001;
                Back(k + 1);
                dir[k] = 0b0101;
                Back(k + 1);
                dir[k] = 0b1010;
                Back(k + 1);
                dir[k] = 0b0110;
                Back(k + 1);
                break;
            case 4 :
                dir[k] = 0b1101;
                Back(k + 1);
                dir[k] = 0b1110;
                Back(k + 1);
                dir[k] = 0b1011;
                Back(k + 1);
                dir[k] = 0b0111;
                Back(k + 1);
                break;
            case 5 :
                dir[k] = 0b1111;
                Back(k + 1);
                break;
        }
    }
}