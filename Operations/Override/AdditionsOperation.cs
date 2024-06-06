using System;

namespace AssignmentThree.Override
{
    public class AdditionOperation : MathOperations
    {
        public AdditionOperation(double operand1, double operand2) : base(operand1, operand2)
        {

        }

        public override double Execute()
        {
            double result = Operand1 + Operand2;
            Console.WriteLine($"Executing addition: {Operand1} + {Operand2} = {result}");
            return result;
        }
    }
}

