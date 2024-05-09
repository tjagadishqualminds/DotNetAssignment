using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Excepitons
{
    internal class ExceptionHandlingOne
    {

        public void exceptionone()
        {
            try
            {
                Console.WriteLine("Enter name");
                  string name = Console.ReadLine();
                if(string.IsNullOrEmpty(name))
                {
                    throw new NullReferenceException();
                }
             
                else
                {

                Console.WriteLine(name);
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
         

        }
    }
}
