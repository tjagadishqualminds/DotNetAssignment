using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne.Loops
{
    internal class Compressed
    {
      

        public void comstr(string com)
        {
          
            string result = "";
            int count = 0;

            for (int i=0;i<com.Length;i++){

                if (i<com.Length-1 && com[i] == com[i + 1])
                {
                    count++;
                }
                else
                {
                   result += com[i];
                    count = 1;
               }

        }
            Console.WriteLine(result);
        }
    }
}
