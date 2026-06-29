using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Easy
{
    public class IsPalindromeSolution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;

            int reversedNumber = 0;
            while (reversedNumber < x)
            {
                reversedNumber = reversedNumber * 10 + x % 10;
                x /= 10;
            }

            return reversedNumber == x || x == reversedNumber / 10;
        }
    }
}
