using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree.InvokeMethods
{
    public class Methods
    {
    //1. value type by value.
        public void methodOne(int x)
        {
            x = x * 2;
         Console.WriteLine(x);
        }
    //2.value type by reference.

        public int methodTwo( ref int x)
        {
            x = x + 2;
             return x;
        }
    //3.reference type by value.

    //4.reference type by reference.

        public string Name { get;set; }



    }
}
