using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSACodingProblems.ArrayProblems
{
    public class ContainsDuplicate
    {
        public bool IfContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int i in nums)
            {
                if (set.Contains(i)) 
                    return true;
                set.Add(i);
            }

            return false;
        }
    }
}
