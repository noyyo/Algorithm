using System;

public class Example
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string[] inputs = input.Split(' ');
        int n = int.Parse(inputs[0]);
        int m = int.Parse(inputs[1]);
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}