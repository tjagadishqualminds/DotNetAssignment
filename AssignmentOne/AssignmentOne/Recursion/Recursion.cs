using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne.Recursion
{
    /// <summary>
    /// Recursion works by defining function that calls itself until it reaches a base case.
    /// The function is called with a set of parameters,and it returns a value.The function then
    /// calls itself with a new set of parameters,and so on,until it reaches the base case.the
    /// base case is a condition that stops the recursion,and it is usually defined as a simple
    /// value or a condition that can be easily evaluated.
    /// 
    /// </summary>
    internal class RecursionFunction

    {
        public int calculate (int baseNum,int exponentNum)
        {
            if (exponentNum == 0)
            {
                return 1;
            }
            else if(exponentNum%2==0){
                return calculate(baseNum*baseNum, exponentNum/2);
            }
            else
            {
                return baseNum*calculate(baseNum*baseNum,(exponentNum -1)/2);
            }
        }
    }
}
