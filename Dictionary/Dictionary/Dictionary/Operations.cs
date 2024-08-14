using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTask.Dictionary
{
      public class Operations
    {
        DictionaryOpeations dictionarydemo = new DictionaryOpeations();

        public void AddElement()
        {
            Console.WriteLine("add element");
            Console.WriteLine("enter id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            dictionarydemo.AddElement(id, name);
        }

        public void PrintELement()
        {
            Dictionary<int, string> pairs = dictionarydemo.PrintElement();

            foreach (KeyValuePair<int, string> pair in pairs)
            {
                Console.WriteLine(pair.Key);
                Console.WriteLine(pair.Value);
            }
        }

        public void DeleteElement()
        {
            Console.WriteLine("Enter id for delete element");
            int deleid = int.Parse(Console.ReadLine());
         bool result= dictionarydemo.RemoveElement(deleid);
            if(result)
            {
               Console.WriteLine("deleted sucessfully");
            }
            else
            {
                Console.WriteLine("id not found");
            }
        }

        public void SingleElement()
        {
            Console.WriteLine("Enter id for Display Element");
               int disid = int.Parse(Console.ReadLine());   
            string name = dictionarydemo.DisplaySingleElement(disid);
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
        public void Listofkeys()
        {
         Console.WriteLine("List of Keys");
            List<int> list = dictionarydemo.ListOfKeys();
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

        public void listToDictionary()
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
