using System;
using System.Collections.Generic;
using System.Text;

namespace IQTest
{
    class IQ
    {
        static int even;
        static int odd;
        static int posEven;
        static int posOdd;

        public static int Test(string numbers)
        {
            string[] nums = numbers.Split(null);

            for (int i = 1; i <= nums.Length; i++)
            {
                int num = Int32.Parse(nums[i-1]);
                ;
                if (num % 2 == 0)
                {
                    even++;
                    posEven = i;
                }
                else
                {
                    odd++;
                    posOdd = i;
                }
            }
            
            if (even == 1) { return posEven; }
            else if (odd == 1) { return posOdd; }
            else return 0;

        }
    }
}
