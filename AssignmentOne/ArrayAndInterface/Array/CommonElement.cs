using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndInterface.Array
{
    public class CommonElement
    {
        public void CommonElementOperationOne()
        {
            int[] arr = { 1, 2, 3, 4, 5, };
            int[] arr2 = { 1, 2, 3, 4, };
            string result = "";
          
            for(int i =0; i < arr.Length; i++)
            {
                for(int j=0;j< arr2.Length; j++)
                {
                    if (arr[i] == arr[j]) { 
                    
                    result += arr[i]+",";
                    }
                }
            }
            Console.WriteLine(result);

        }
    }
}
