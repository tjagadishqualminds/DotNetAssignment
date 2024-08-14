using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exceptions.Exceptions
{
    public class ExceptionHandlingTwo
    {
        public void ExceptionNullReference()
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
           catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         
    }
}
}
