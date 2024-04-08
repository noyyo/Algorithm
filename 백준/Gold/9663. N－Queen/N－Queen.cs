using System;

class Solution
{
    int n;
    int count = 0;
    bool[] column;
    bool[] diagonal1;
    bool[] diagonal2;
    
    public Solution(int n)
    {
        this. n = n;
        column = new bool[n];
        diagonal1 = new bool[2 * n - 1];
        diagonal2 = new bool[2 * n - 1];
    }
    
    public static void Main()
    {
        Solution sol = new Solution(int.Parse(Console.ReadLine()));
        sol.Back(0);
        Console.Write(sol.count);
    }
    private void Back(int row)
    {
        if (row == n)
        {
            count++;
            return;
        }
        for (int col = 0; col < n; col++)
        {
            if (column[col])
                continue;
            if (diagonal1[row + col])
                continue;
            if (diagonal2[row - col + n - 1])
                continue;
            column[col] = true;
            diagonal1[row + col] = true;
            diagonal2[row - col + n - 1] = true;
            Back(row + 1);
            column[col] = false;
            diagonal1[row + col] = false;
            diagonal2[row - col + n - 1] = false;
        }
    }
}