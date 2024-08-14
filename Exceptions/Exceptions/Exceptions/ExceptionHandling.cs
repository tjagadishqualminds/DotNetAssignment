using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Exceptions
{
    public class ExceptionHandling
    {
        public void ExceptionOperation()
        {

          //Exceptions
            try
            {
                Console.WriteLine("User details");
                Console.WriteLine("Enter user id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine(" ENTER num1");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine(num1/0);
            }
            
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message + "cannot divide by zero");
            }
            
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + "id should be numeric and should not be empty string");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
      


        }
        }
    }

