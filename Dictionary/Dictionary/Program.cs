using System.Security.Cryptography.X509Certificates;
using DictionaryTask.Dictionary;
using DictionaryTask.Extension;

namespace Dictionary
{
   public class Program
    {
        enum options
        {
         AddElement,
         PrintElement,
         DeleteElement,
         DisplaySingleElement,
         CreateList,
         Listtodictionary
        }

 
        static void Main(string[] args)
        { 

            //extensionsmethods

            ExtensionMethod method = new ExtensionMethod();
            method.Add(10,2);
            method.Sub(10, 2);
            method.Multi(10, 2);

            int x = 5;
            long result = x.Factorial();

            Console.WriteLine(result);
            string str = "hello world";
            Console.WriteLine(str.ToProperCase());

            //Dictionary

            Operations operations = new Operations();
            while (true)
            {
                Console.WriteLine("Enter your options \n 0. AddElement \n 1.PrintElement \n 2.DeleteElement,\n 3.DisplaySingleElement,\n 4.CreateList\n 5. Listtodictionary");
                int choice = int.Parse(Console.ReadLine());
                Enum @enum = (options)choice;

                switch (@enum)
                {
                    case options.AddElement:
                        operations.AddElement();
                        break;
                    case options.PrintElement:
                        operations.PrintELement();
                        break;
                    case options.DeleteElement:
                        operations.DeleteElement();
                        break;
                    case options.DisplaySingleElement:
                        operations.SingleElement();
                        break;
                    case options.CreateList:
                        operations.Listofkeys();
                        break;
                    case options.Listtodictionary:
                        operations.listToDictionary();
                        break;
                }

            }

        }
       
    }
}
