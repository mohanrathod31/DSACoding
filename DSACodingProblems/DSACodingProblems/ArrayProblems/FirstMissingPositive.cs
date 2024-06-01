using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSACodingProblems.ArrayProblems
{
    public class FirstMissingPositive
    {
        public int FindFirstMissingPositive(int[] nums) 
        {
            int missingNumber = 1;

            Array.Sort(nums);

            return missingNumber;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == missingNumber)
                    missingNumber++;
                else if (nums[i] > missingNumber)
                    break;
            }

            return missingNumber;
        }
    }
}
