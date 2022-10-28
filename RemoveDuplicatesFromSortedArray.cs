using System;

namespace RemoveDuplicatesFromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4};

            int numberOfDupes = removeDuplicates(nums);
            Console.WriteLine(numberOfDupes);

            for (int i = 0; i < numberOfDupes; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        //Time Complexity is O(n), Space complexity is O(1)
        public static int removeDuplicates(int[] nums)
        {
            int count = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if(i < nums.Length -1 && nums[i] == nums[i + 1])
                {
                    continue;
                }
                nums[count] = nums[i];
                count++;
            }
            return count;
        }
    }
}
