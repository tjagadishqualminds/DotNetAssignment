using AssignmentThree.Abstract;
using AssignmentThree.InvokeMethods;
using AssignmentThree.InvokeMethodTwo;
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


  


            Console.ReadKey();

           

        }
    }
}
