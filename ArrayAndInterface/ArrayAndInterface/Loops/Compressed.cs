using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndInterface.Loops
{
    public class Compressed
    {
        public void CompressedString (string com)
        {
            string result = "";
            int count = 1;

            for (int i=0;i<com.Length;i++){

                if (i<com.Length-1 && com[i] == com[i + 1])
                {
                    count++;
                }
                else
                {
                    result += com[i];
                    result += count;
                    count = 1;
                }
            }
            Console.WriteLine(result);
        }
    }
}
