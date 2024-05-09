using Assignment2.Dictionary;
using Assignment2.Excepitons;
using Assignment2.Extension;
using System.Security.Cryptography.X509Certificates;

namespace Assignment2
{
    internal class Program
    {
        enum options
        {
         AddElement,
         PrintElement,
         DeleteElement,
         DisplaySingleElement,
         CreateList,
         Listtodictionary
        }

 
        static void Main(string[] args)
        {
            //Exceptionsone
            ExceptionHandlingOne exceptionone = new ExceptionHandlingOne();
            exceptionone.exceptionone();

            ////Exceptionstwo
            ExceptionHandling exception = new ExceptionHandling();
            exception.exception();

            //extensionsmethods
            ExtensionMethod method = new ExtensionMethod();
            method.Test1();
            method.Test2();
            method.Test3();

            int x = 5;
            long result = x.Factorial();

            Console.WriteLine(result);
            string str = "hello world";
            Console.WriteLine(str.ToProper());

            operations operations = new operations();
            while (true)
            {

                Console.WriteLine("Enter your options \n 0. AddElement \n 1.PrintElement \n 2.DeleteElement,\n 3.DisplaySingleElement,\n 4.CreateList\n 5. Listtodictionary");
                int choice = int.Parse(Console.ReadLine());
                Enum @enum = (options)choice;

                switch (@enum)
                {
                    case options.AddElement:
                        operations.addEle();
                        break;
                    case options.PrintElement:
                        operations.printELe();
                        break;
                    case options.DeleteElement:
                        operations.deleteEle();
                        break;
                    case options.DisplaySingleElement:
                        operations.singleEle();
                        break;
                    case options.CreateList:
                        operations.listofkeys();
                        break;
                    case options.Listtodictionary:
                        operations.listToDic();
                        break;


                }

            }



        }
       
    }
}
