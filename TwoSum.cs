/*1. Two Sum C#
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.
*/

using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] resultOfTwoSum = twoSum(new int[] { 1, 5, 7, 9, 2 }, 10);
            Console.WriteLine("Brute Force");
            Console.WriteLine("Time Complexity: O(n^2), Space complexity: O(1)");
            Console.WriteLine(String.Join(" , ", resultOfTwoSum));

            int[] resultOfOptimizedTwoSum = TwoSumeOptimized(new int[] { 2, 7, 11, 15 }, 9);
            Console.WriteLine("Optimized");
            Console.WriteLine("Time Complexity: O(n), Space complexity: O(n)");
            Console.WriteLine(String.Join(" , ", resultOfOptimizedTwoSum));
        }

        // Brute Force approach...Add one element of the array with every other element in the array to cover all possibilities.
        // Iterate through loop twice we have:
        // Time Complexity of O(n^2) and Space Complexity O(1).
        public static int[] twoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++) {
                for (var j = nums.Length - 1; j > i; j--) {
                    if (i != j) {
                        if (nums[i] + nums[j] == target) {
                            return new int[] { i, j };
                        }
                    }
                }
            }
            return new int[] { };
        }

        // Optimized approach...If I start iterating through a loop, I get to the first element which is 2.
        // Let's deduct these 2 from the target which is 9: will get 7.
        // let's add 2 to the dictionary with its index, Now dictionary will have [2, 0]
        // Going for the second iteration.Next value is 7.
        // Again did the deduction: 9-7: will get 2. We will see if the dictionary has an entry of 2. Yes it has.
        // Well these are the 2 indices that makes the sum, so just return the value from the dictionary(index of 2) and the current value of i(index of 7). Because 2 + 7 = 9.
        // Time Complexity: O(n) since we are iterating the loop once and Space complexity would be O(n).
        public static int[] TwoSumeOptimized(int[] nums, int target)
        {
            int arrayLegth = nums.Length;
            Dictionary<int, int> resultDictionary = new Dictionary<int, int>();

            if (nums == null || arrayLegth < 2)
                return Array.Empty<int>();

            for(int i = 0; i < nums.Length; i++)
            {
                int firstNum = nums[i];
                int secondNum = target - firstNum;
                
                if( resultDictionary.TryGetValue(secondNum, out int index)) //check if dictionary has entry
                {
                    return new[]
                    {
                        index,
                        i
                    };
                }
                resultDictionary[firstNum] = i;
            }
            return new int[] { };
        }
    }
}
