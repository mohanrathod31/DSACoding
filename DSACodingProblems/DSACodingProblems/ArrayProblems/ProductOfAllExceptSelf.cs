using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSACodingProblems.ArrayProblems
{
    public class ProductOfAllExceptSelf
    {
        public int[] productExceptSelf(int[] nums)
        {
            //Get length of given array
            int n = nums.Length;

            //Declare result array 
            int[] res = new int[];

            //initialize productOfAllBeforeCurrent 1
            // initialize productOfAllAfterCurrent 1

            int productOfAllBeforeCurrent = 1;
            int productOfAllAfterCurrent = 1;

            for (int i = 0; i < n; i++)
            {
                res[i] = productOfAllBeforeCurrent;
                //gives product all elements before i
                productOfAllBeforeCurrent *= nums[i];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                res[i] *= productOfAllAfterCurrent;
                productOfAllAfterCurrent *= nums[i];
            }

            return res;
        }
    }
}
