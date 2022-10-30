using System;

namespace _88Merge_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //space compexity: O(1)
        //time complexity: O(m + n)
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p = m + n - 1;
            int p1 = m - 1;
            int p2 = n - 1;

            while(p1 >= 0 && p2 >= 0)
            {
                if (nums1[p1] > nums2[p2])
                {
                    nums1[p] = nums1[p1];
                    p1--;
                    p--;
                }
                else
                {
                    nums1[p] = nums2[p2];
                    p2--;
                    p--;
                }       
            }
            while (p2 >= 0)
            {
                nums1[p] = nums2[p2];
                p2--;
                p--;
            }         
        }
    }
}
