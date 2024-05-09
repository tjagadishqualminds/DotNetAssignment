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



        }
    }
}
