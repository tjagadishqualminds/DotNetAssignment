using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndInterface.Array
{
    public class Reverse
    {
  // Write a program to REVERSE the number
        public int ReversedNumber(int num)
        {
            int reverse = 0, rem;
            while (num > 0)
            {
                rem = num % 10;//2 //2/1
                reverse = reverse * 10 + rem;//2//22//221
                num =num/ 10;//12//1/
            }
            return reverse;
        }

    }
}
