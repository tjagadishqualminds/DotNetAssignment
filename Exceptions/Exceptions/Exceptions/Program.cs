using Exceptions.Exceptions;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //ExceptionHandling exceptionHandling = new ExceptionHandling();
           // exceptionHandling.ExceptionOperation();
            ExceptionHandlingTwo exceptionHandlingTwo = new ExceptionHandlingTwo();
            exceptionHandlingTwo.ExceptionNullReference();
        }
    }
}
