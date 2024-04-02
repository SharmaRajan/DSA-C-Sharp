using System;

/*
 * Date: 30 Mar 2024
 * https://leetcode.com/problems/subarrays-with-k-different-integers/description/?envType=daily-question&envId=2024-03-30
 */

namespace DSA_Practice.LeetCodeOwn.DailPractice.Hard
{
	public class SubArrKDistinct
	{
        //static void Main(string[] args)
        //{
            //int[] nums = {1,2,1,2,3};
            //int k = 2;

            //SubArrKDistinct sub = new SubArrKDistinct();
            //int result = sub.SubarraysWithKDistinct(nums,k);
            //Console.WriteLine("Result: " + result);
        //}

        public int SubarraysWithKDistinct(int[] nums, int k)
        {
            return countArray(nums, k) - countArray(nums, k - 1);
        }

        private int countArray(int[] nums, int k)
        {
            int count = 0;
            int[] occur = new int[nums.Length + 1];
            int i = 0, j = 0;
            int unique = 0;

            while (j < nums.Length)
            {
                if (occur[nums[j]] == 0)
                    unique++;
                occur[nums[j]]++;
                while (i <= j && unique > k)
                {
                    occur[nums[i]]--;
                    if (occur[nums[i++]] == 0)
                        unique--;
                }
                count += j - i + 1;
                j++;
            }
            return count;
        }
    }
}

