using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AssignmentThree.InvokeMethodTwo
{
    internal class MethodsTwo
    {
    //2. Create some methods in a class and Invoke them by passing:

  // Variable.
        public void DoAdd(int num)
        {
            Console.WriteLine($"Number added: {num + num}");
        }
        // Literal.
        public void DoSub(int num,int num2)
        {
            Console.WriteLine($"Number sub: {num - num2}");
        }
        //expression.
        public void DoMult(int num)
        {
            Console.WriteLine($"Number MULT: {num }");
        }
        //positional arguments.
        public void MethodWithPositionalArgs(int a, int b)
        {
            Console.WriteLine($"MethodWithPositionalArgs: a = {a}, b = {b}");
        }

        //optional arguments and
        public void MethodWithOptionalArgs(int a, int b = 20)
        {
            Console.WriteLine($"MethodWithOptionalArgs: a = {a}, b = {b}");
        }
        //named arguments
        public void MethodWithNamedArgs(int a, int b)
        {
            Console.WriteLine($"MethodWithNamedArgs: a = {a}, b = {b}");
        }

    }
}
