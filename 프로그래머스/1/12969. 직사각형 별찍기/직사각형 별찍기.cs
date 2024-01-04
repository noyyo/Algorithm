using System;
using System.Text;

public class Example
{
    public static void Main()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        int n = Int32.Parse(input[0]);
        int m = Int32.Parse(input[1]);
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            sb.Append("*");
        }
        for (int j = 0; j < m; j++)
        {
            Console.WriteLine(sb.ToString());
        }
    }
}