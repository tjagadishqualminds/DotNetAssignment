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
            string name = null;

                if (name == null)
                {
                    throw new NullReferenceException();
                }

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
