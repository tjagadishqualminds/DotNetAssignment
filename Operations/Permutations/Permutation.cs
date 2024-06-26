using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree.Permutations
{
    internal class Permutation
    {
       public void GeneratePermutations(char[] chars, int index)
        {
            if (index == chars.Length - 1)
            {
                Console.WriteLine(new string(chars));
            }
            else
            {
                for (int i = index; i < chars.Length; i++)
                {
                    Swap(ref chars[index], ref chars[i]);
                    GeneratePermutations(chars, index + 1);
                    Swap(ref chars[index], ref chars[i]);
                }
            }
        }

    public void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            char temp = a;
            a = b;
            b = temp;
        }
    }
}
