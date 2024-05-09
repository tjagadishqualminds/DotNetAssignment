using Assignment2.Excepitons;
using Assignment2.Extension;
using System.Security.Cryptography.X509Certificates;

namespace Assignment2
{
    internal class Program
    {

 
        static void Main(string[] args)
        {
            //Exceptionsone
            ExceptionHandlingOne exceptionone = new ExceptionHandlingOne();
            exceptionone.exceptionone();

            //Exceptionstwo
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

            Console.ReadLine();

        }
    }
}
