using System;

namespace PlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9) {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }

            int[] result = new int[digits.Length + 1]; // digits = [0,0,0,0] // result = [0,0,0,0,0]
            result[0] = 1; // result = [1,0,0,0,0,]
            return result;
        }
    }
}
