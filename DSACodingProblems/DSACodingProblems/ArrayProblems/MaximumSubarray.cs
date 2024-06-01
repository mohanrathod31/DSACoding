using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSACodingProblems.ArrayProblems
{
    public class MaximumSubarray
    {
        public int SubArrayOfMaximumSum(int[] nums)
        {
            int sum = 0;

            int Max_Sum = 0;

            for(int i = 0; i < nums.Length; i++)
            {

                sum += nums[i];
                if(sum >  Max_Sum) 
                    Max_Sum = sum;
                if (sum < 0)
                    Max_Sum = 0;
            }

            return Max_Sum;
        }
    }
}
