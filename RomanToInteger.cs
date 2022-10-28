using System;
using System.Collections.Generic;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string s = "LVIII";
            Console.WriteLine(romanToInt(s));
        }

        public static int romanToInt(string s)
        {
            int sum = 0;
            Dictionary<char, int> romanNumbers = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            for(int i = 0; i <s.Length; i++)
            {
                romanNumbers.TryGetValue(s[i], out int num);
                if (i + 1 < s.Length && romanNumbers[s[i + 1]] > romanNumbers[s[i]])
                {
                    sum -= num;
                }
                else
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}
