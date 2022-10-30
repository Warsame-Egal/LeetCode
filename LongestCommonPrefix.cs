using System;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }

            string prefix = strs[0]; //"[flower] just get the first string in the array
            for (int i = 1; i < strs.Length; i++)
            { //["flow", "fight"] loop through the rest of the strings
                while (strs[i].IndexOf(prefix) != 0) //while "flower" is at the begining take a character off
                {
                    prefix = prefix.Substring(0, prefix.Length - 1); //trims the last char at each iteration with this line:
                }
            }
            return prefix;

        }
    }
}
