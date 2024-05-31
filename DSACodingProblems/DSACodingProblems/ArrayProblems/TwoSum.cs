using System;
using System.Collections.Generic;

namespace DSACodingProblems.ArrayProblems
{
    public class TwoSum
    {
        // Method to find two indices such that their sum is equal to target using brute force approach
        public static int[] TwoSumBruteForce(int[] nums, int target)
        {
            // Loop through each element in the array
            for (int i = 0; i < nums.Length; i++)
            {
                // Loop through each element after the current element
                for (int j = i + 1; j < nums.Length; j++)
                {
                    // Check if the sum of the current pair equals the target
                    if (nums[i] + nums[j] == target)
                    {
                        // Return the indices of the elements that sum to the target
                        return new int[] { i, j };
                    }
                }
            }
            // If no such pair is found, throw an exception
            throw new ArgumentException("No two sum solution");
        }

        // Method to find two indices such that their sum is equal to target using sorting and two-pointer approach
        public int[] TwoSumSorting(int[] nums, int target)
        {
            // Create a copy of the array and sort it
            int[] copyArray = (int[])nums.Clone();
            Array.Sort(copyArray);

            int head = 0;
            int tail = copyArray.Length - 1;
            int num1 = 0, num2 = 0;

            // Use two pointers to find the two numbers that sum to the target
            while (head < tail)
            {
                int sum = copyArray[head] + copyArray[tail];
                if (sum < target)
                {
                    head++;
                }
                else if (sum > target)
                {
                    tail--;
                }
                else
                {
                    num1 = copyArray[head];
                    num2 = copyArray[tail];
                    break;
                }
            }

            // Create the result array with indices
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == num1) result[0] = i;
                if (nums[i] == num2) result[1] = i;
            }
            return result;
        }

        // Method to find two indices such that their sum is equal to target using a hash map
        public static int[] TwoSumHashing(int[] nums, int target)
        {
            // Create a dictionary to store the numbers and their indices
            Dictionary<int, int> map = new Dictionary<int, int>();

            // Loop through each element in the array
            for (int i = 0; i < nums.Length; i++)
            {
                // Calculate the complement of the current element
                int complement = target - nums[i];

                // Check if the complement is already in the dictionary
                if (map.ContainsKey(complement))
                {
                    // Return the indices of the complement and the current element
                    return new int[] { map[complement], i };
                }

                // Add the current element and its index to the dictionary
                map[nums[i]] = i;
            }
            // If no such pair is found, throw an exception
            throw new ArgumentException("No two sum solution");
        }
    }
}
