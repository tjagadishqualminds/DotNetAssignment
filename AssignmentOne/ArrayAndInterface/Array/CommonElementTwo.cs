﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArrayAndInterface.Array
{
    public class CommonElementTwo
    {
        //Print the elements with no of times it repeated in the array and remove duplicate elements from an Array

        public void CommonElementOperationTwo()
        {
            int[] arr = { 1, 2,2,1};
            int count = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != -1)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                            arr[j] = -1;
                        }

                    }
                    Console.WriteLine(arr[i] + " occurs " + (count) + " times");
                }
                count = 1;
            }
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != -1)
                {
                    result += arr[i]+",";
                }
            }
            Console.WriteLine(result);
        }
    }
}
