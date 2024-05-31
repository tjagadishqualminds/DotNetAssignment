using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree.Override
{
  public  class MathOperations
    {
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }

        public MathOperations(double operand1, double operand2)
        {
            Operand1 = operand1;
            Operand2 = operand2;
        }

        public virtual double Execute()
        {
            Console.WriteLine("Executing base operation");
            return 0; // Default implementation, does nothing
        }
    }

}
