using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTask.Extension
{
   static internal class ExternsionOperation
    {
        public static void Multi(this ExtensionMethod  method , int x ,int y  )
        {
            Console.WriteLine(x*y);
        }
        public static long Factorial(this Int32 x)
        {
            if (x == 1) return 1;
            if (x == 2) return 2;
            else
            {
                return x * Factorial(x - 1);
            }
        }

        public static string ToProperCase(this String OldStr)
        {
            if (OldStr.Trim().Length > 0)
            {
                String NewStr = null;
                OldStr = OldStr.ToLower();
                string[] sarr = OldStr.Split(' ');
                foreach (string str in sarr)
                {

                    char[] carr = str.ToCharArray();
                    carr[0] = char.ToUpper(carr[0]);
                    if (NewStr == null)
                    {
                        NewStr = new String(carr);
                    }
                    else
                    {
                        NewStr += " " + new String(carr);
                    }

                }
                return NewStr;
            }
            return OldStr;
        }


    }
}
