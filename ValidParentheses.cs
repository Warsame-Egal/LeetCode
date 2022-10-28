using System;
using System.Collections;
using System.Collections.Generic;

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
  
        }
            public static bool IsValid(string s)
            {
                Stack<Char> stack = new Stack<Char>();

                foreach (char c in s)
                {
                    if (c == '(')
                    {
                        stack.Push(c);
                    }
                    else if (c == '{')
                    {
                        stack.Push(c);
                    }
                    else if (c == '[')
                    {
                        stack.Push(c);
                    }
                    else if (c == ')')
                    {
                        if (stack.Peek().ToString() == "(") { stack.Pop(); }
                        else
                            return false;
                    }
                    else if (c == '}')
                    {
                        if (stack.Peek().ToString() == "{") { stack.Pop(); }
                        else
                            return false;
                    }
                    else if (c == ']')
                    {
                        if (stack.Peek().ToString() == "[") { stack.Pop(); }
                        else
                            return false;
                    }
                }
                return true;
            }
        }
    
}
