using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTask.Extension
{
  public class ExtensionMethod
    {
        //extension methods
        // it's a mechanism of adding new methods into an existing class or structure also with out modifying the source code of the original type
        //in this process we don't require any permsissions from original type and the original type doesn't require any re-compilation
        //extension methods are define as static but once they are bound with any class or structure they turn into non-static
        // inheritance is a mechanism using which we can extend the functionalities of a class;
        //we can't  apply inheritance in sealed;
        //if the original type is not a class and its a structure

        public void Add( int x ,int y)
        {
            Console.WriteLine(  x + y );
        }
        public void Sub( int x ,int y )
        {
          Console.WriteLine ( x - y );
        }


    }
}
