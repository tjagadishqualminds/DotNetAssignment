using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree.InvokeOperations
{
    public class OperationsOne
    {
        // Invoke methods by passing arguments by

        //1. value type by value.
        public void PassByValue(int num)
        {
            num = 10;
        }

        //2.value type by reference.
        public void PassByReference(ref int num)
        {
            num = 10;
        }

        //3.reference type by value.
        public void PassReferenceTypeByValue(int[] num)
        {
            num[0] = 20;
        }

        //4.reference type by reference.
        public void PassReferenceTypeByReference(ref int[] num)
        {
            num[0] = 10;
        }


    }
}

//value type int ,byte
//class ,obje are referencetyp store in heap memory
//can acccess garbage collector