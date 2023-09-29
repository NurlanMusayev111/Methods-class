using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_methods
{
    internal class CustomMath
    {
        public void OddNumbers(int[] nums)
        {
            int sum = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 1)
                {
                    sum += i;
                }
            }
        }
    }
}
