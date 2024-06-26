using AssignmentThree.Override;
using AssignmentThree.InvokeOperations;
using AssignmentThree.InvokeOperationTwo;
using AssignmentThree.Permutations;

namespace AssignmentThree
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            //one
            int[] num = { 1, 2, 3, 4, 5 };
            OperationsOne operations = new OperationsOne();
            Console.WriteLine($"BeforePassingValue:num[0] : {num[0]}");
            operations.PassByValue(num[0]);
            Console.WriteLine($"AfterPassingValue:num[0] : {num[0]}");

            Console.WriteLine($"BeforePassingReference:num[0] : {num[0]}");
            operations.PassByReference(ref num[0]);
            Console.WriteLine($"AfterPassingReference:num[0] : {num[0]}");


            Console.WriteLine($"BeforePassingReferenceTypeByValue:num[0] : {num[0]}");
            operations.PassReferenceTypeByValue(num);
            Console.WriteLine($"AfterPassingReferenceTypeByValue:num[0] : {num[0]}");

            Console.WriteLine($"BeforePassingReferenceTypeByReference:num[0] : {num[0]}");
            operations.PassReferenceTypeByReference(ref num);
            Console.WriteLine($"AfterPassingReferenceTypeByReference:num[0] : {num[0]}");


            //two
            //variable
            int numTwo = 12;
            OpeationsTwo operationsTwo = new OpeationsTwo();
            operationsTwo.DoAdd(numTwo);
            operationsTwo.DoSub(10, 2);
            operationsTwo.DoMult(10 * 2);
            operationsTwo.PositionalArgs(10, 23);
            operationsTwo.OptionalArgs(10);
            operationsTwo.OptionalArgs(10, 30);
            operationsTwo.NamedArgs(a: 10, b: 20);


            //three
            MathOperations operation = new MathOperations(10, 10);
            double resultOne = operation.Execute();
            Console.WriteLine(resultOne);

            MathOperations addition = new AdditionOperation(10, 10);
            double resultTwo = addition.Execute();
            Console.WriteLine(resultTwo);

            MathOperations subtraction = new SubtractionOperation(10, 10);
            double resultThree = subtraction.Execute();
            Console.WriteLine(resultThree);

            //four
            string input = "abc";
            Permutation permutation = new Permutation();
            permutation.GeneratePermutations(input.ToCharArray(), 0);

            Console.ReadKey();

           

        }
    }
}
