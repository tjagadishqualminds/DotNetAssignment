using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Excepitons
{
    internal class ExceptionHandling
    {
        public void exception()
        {

            //Exceptions

            try
            {
                Console.WriteLine("User details");
                Console.WriteLine("Enter user id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                Console.WriteLine(name.ToUpper());
              if(string.IsNullOrEmpty(name))
                {
                    throw new NullReferenceException();
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
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

