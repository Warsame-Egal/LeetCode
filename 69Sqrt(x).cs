using System;

namespace _69Sqrt_x_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MySqrt(4));
        }

        public static int MySqrt(int x)
        {
            long start = 0;
            long end = x;

            while (start + 1 < end)
            {
                long mid = start + (end - start) / 2;
                if (mid * mid == x)
                    return (int)mid;
                
                else if (mid * mid < x)
                    start = mid;
    
                else
                    end = mid;              
            }

            if (end * end == x)
                return (int)end;

            return (int)start;
        }
    }
}
