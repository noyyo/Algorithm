using System;
using System.Collections.Generic;

class Solution
{
    public static void Main(string[] args)
    {
        Stack<char> bracket = new Stack<char>();
        string? s = Console.ReadLine();
        while(s != null)
        {
            if (s[0] == '.')
                break;
            bool isWrong = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[')
                    bracket.Push(s[i]);
                else if (s[i] == ')')
                {
                    if(bracket.TryPeek(out char c))
                    {
                        if (c == '(')
                            bracket.Pop();
                        else
                            isWrong = true;
                    }
                    else
                        isWrong = true;
                }
                else if (s[i] == ']')
                {
                    if(bracket.TryPeek(out char c))
                    {
                        if (c == '[')
                            bracket.Pop();
                        else
                            isWrong = true;
                    }
                    else
                        isWrong = true;
                }
                if (isWrong)
                    break;
            }
            if (bracket.Count > 0)
                isWrong = true;
            if (isWrong)
                Console.WriteLine("no");
            else
                Console.WriteLine("yes");
            s = Console.ReadLine();
            bracket.Clear();
        }
    }
}