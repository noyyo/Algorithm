using System;

class Solution
{
    int n;
    int maxNum = 0;
    int[] dx = { 1, 0, -1, 0 };
    int[] dy = { 0, 1, 0, -1 };
    public Solution()
    {
        n = int.Parse(Console.ReadLine());
        int[ , ] map = new int [n, n];
        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            string[] sSplit = s.Split(" ");
            for (int j = 0; j < n; j++)
                map[i, j] = int.Parse(sSplit[j]);
        }
        Back(0, map, 0, true);
        Back(0, map, 1, true);
        Back(0, map, 2, true);
        Back(0, map, 3, true);
    }
    public static void Main()
    {
        Solution sol = new Solution();
        Console.Write(sol.maxNum);
    }
    private void Back(int k, int[ , ] map, int dir, bool combineExist)
    {
        if (k == 5)
        {
            GetMaxBlock(map);
            return;
        }
        int[ , ] newMap = new int[n, n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                newMap[i, j] = map[i, j];
        bool isCombined = false;
        (int x, int y) startPos = dir switch
        {
            0 => (0, 0),
            1 => (n - 1, 0),
            2 => (n - 1, n - 1),
            3 => (0, n - 1),
        };
        for (int i = 0; i < n; i++)
        {
            var cur = startPos;
            int lastNum = 0;
            int index = 0;
            int zeroCount = 0;
            while (index < n)
            {
                ref int curNum = ref newMap[cur.x, cur.y];
                if (curNum == 0)
                {
                    zeroCount++;
                    if (index + zeroCount >= n)
                        break;
                    curNum = newMap[cur.x + (dx[dir] * zeroCount), cur.y + (dy[dir] * zeroCount)];
                    newMap[cur.x + (dx[dir] * zeroCount), cur.y + (dy[dir] * zeroCount)] = 0;
                    continue;
                }
                else if (curNum == lastNum)
                {
                    isCombined = true;
                    newMap[cur.x - dx[dir], cur.y - dy[dir]] = curNum * 2;
                    curNum = 0;
                    lastNum = 0;
                    zeroCount = 0;
                    continue;
                }
                else
                {
                    lastNum = curNum;
                    zeroCount = 0;
                }
                cur.x += dx[dir];
                cur.y += dy[dir];
                index++;
            }
            startPos.x += dx[(dir + 1) % 4];
            startPos.y += dy[(dir + 1) % 4];
        }
        if (!isCombined && !combineExist)
        {
            GetMaxBlock(newMap);
            return;
        }
        Back(k + 1, newMap, 0, isCombined);
        Back(k + 1, newMap, 1, isCombined);
        Back(k + 1, newMap, 2, isCombined);
        Back(k + 1, newMap, 3, isCombined);
    }
    private void GetMaxBlock(int[ , ] map)
    {
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (map[i, j] > maxNum)
                    maxNum = map[i, j];
    }
}