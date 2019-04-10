using System;
using System.Collections.Generic;

namespace two_sum
{
    class Program
    {
        //Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.

        //Example:

        //Given nums = [2, 7, 11, 15], target = 9,

        //Because nums[0] + nums[1] = 2 + 7 = 9, return [0, 1].
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;

            var result = TwoSum(nums, target);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            IDictionary<int, int> dic = new Dictionary<int, int>();
            int complement;

            //// Beter solution with O(n)
            for (int i = 0; i < nums.Length; i++)
            {
                complement = target - nums[i];
                if (dic.ContainsKey(complement))
                {
                    result[0] = i;
                    result[1] = dic[complement];

                    return result;
                }

                // if the complement is not in the dictionary add the current element, 
                // which will be matched
                dic[nums[i]] = i;
            }

            //// Simplest solution O(n2)
            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] + nums[j] == target)
            //        {
            //            result[0] = i;
            //            result[1] = j;

            //            return result;
            //        }
            //    }
            //}

            throw new ArgumentException("Given numbers input doesn't have a solution");
        }

    }
}
