using AssignmentThree.Abstract;
using AssignmentThree.InvokeMethods;
using AssignmentThree.InvokeOperationTwo;
using AssignmentThree.Permutations;

namespace AssignmentThree
{
    internal class Program
    {
        static void ModifyPersonName(Methods methods)
        {
            methods.Name = "jagadish";
        }
        static void ModifyPersonNametwo( ref Methods methods)
        {
            methods.Name = "jagadish";
        }
        static void Main(string[] args)
        {
            int num = 12;
            int num2 = 12;
           //one
           Methods methods = new Methods();
            methods.methodOne(num);

            int result = methods.methodTwo(ref num2);
            Console.WriteLine(result);

         
            Methods method = new Methods { Name = "ALDKSF"};
             ModifyPersonName(method);
            Console.WriteLine(method.Name);

            Methods method3 = new Methods { Name = "ALDKSF" };
            ModifyPersonNametwo( ref method3);
            Console.WriteLine(method.Name);

            //two
            //variable
            OpeationsTwo operationsTwo = new OpeationsTwo();
            operationsTwo.DoAdd(num);
            operationsTwo.DoSub(10, 2);
            operationsTwo.DoMult(10 * 2);
            operationsTwo.PositionalArgs(10, 23);
            operationsTwo.OptionalArgs(10);
            operationsTwo.OptionalArgs(10, 30);
            operationsTwo.NamedArgs(a: 10, b: 20);


            //three
            Circle circle = new Circle();
            circle.Draw();

            //four
            string input = "abc";
            Permutation permutation = new Permutation();
            permutation.GeneratePermutations(input.ToCharArray(), 0);

            Console.ReadKey();

           

        }
    }
}
