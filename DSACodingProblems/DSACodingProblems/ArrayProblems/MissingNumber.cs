using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSACodingProblems.ArrayProblems
{
    public class MissingNumber
    {
        public int FindMissingNumber(int[] nums) 
        {
            int missingNumber = 0;
            int sum = 0;
            int actualSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            actualSum = (nums.Length * (nums.Length + 1)) / 2;
            missingNumber = actualSum - sum;

            return missingNumber;
        
        }
    }
}
