using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Dictionary
{
      public class operations
    {
       dictionarydemo dictionarydemo = new dictionarydemo();

        public void addEle()
        {
            Console.WriteLine("add element");
            Console.WriteLine("enter id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            dictionarydemo.addElement(id, name);
        }

        public void printELe()
        {
            Dictionary<int, string> pairs = dictionarydemo.printElement();

            foreach (KeyValuePair<int, string> pair in pairs)
            {
                Console.WriteLine(pair.Key);
                Console.WriteLine(pair.Value);
            }
        }

        public void deleteEle()
        {
            Console.WriteLine("Enter id for delete element");
            int deleid = int.Parse(Console.ReadLine());
         bool result= dictionarydemo.removElement(deleid);
            if(result)
            {
               Console.WriteLine("deleted sucessfully");
            }
            else
            {
                Console.WriteLine("id not found");
            }
        }

        public void singleEle()
        {
            Console.WriteLine("Enter id for Display Element");
               int disid = int.Parse(Console.ReadLine());   
            string name = dictionarydemo.displaySingleElement(disid);
            if(name != null)
            {
                Console.WriteLine("Element found");
            Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }
        public void listofkeys()
        {
         Console.WriteLine("List of Keys");
            List<int> list = dictionarydemo.listOfKeys();
            if(list != null)
            {
                foreach(int i in list)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("no elements");
            }
        }

        public void listToDic()
        {
            Dictionary<int, string> pairs = dictionarydemo.ListOfString();

            foreach (KeyValuePair<int, string> pair in pairs)
            {
                Console.WriteLine(pair.Key);
                Console.WriteLine(pair.Value);
            }
        }



    }
}
