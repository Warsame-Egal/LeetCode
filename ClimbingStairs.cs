/*70 CClimbing Stairs 
 * You are climbing a staircase. It takes n steps to reach the top.
 * Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
 */
using System;

namespace _70Climbing_Stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(climbingStairs(4));
            
        }

        public static int climbingStairs(int n)
        {
            int[] dp = new int[n + 1];
            dp[1] = 1; // one way to climb by not climbing
            dp[2] = 2; // one way to climb by going one step
            
            for(int i = 3; i <= n; i++) // solve 2 steps up to n steps
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }
    }
}
