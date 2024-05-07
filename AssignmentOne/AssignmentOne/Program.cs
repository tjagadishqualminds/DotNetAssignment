using AssignmentOne.Array;
using AssignmentOne.Interface;
using AssignmentOne.Loops;
using AssignmentOne.Recursion;

namespace AssignmentOne
{
    internal class Program
    {

        static void Main()
        {
          //compressedstring
            Compressed compressed = new Compressed();
            compressed.comstr("jjaaggaaddiisshh");


            Commonele commonele = new Commonele();
            commonele.commonelement();

            //commonelement
            Commoneletwo commoneletwo = new Commoneletwo();
            commoneletwo.commoneletwo();

            //reverse number
            Reverse number = new Reverse();
           int rs= number.ReversedNumber(122);
            Console.WriteLine( "reversenumber"+rs);


            //Recursion
            int baseNumber = 5;
            int exponent = 3;
            RecursionFunction recursionFunction = new RecursionFunction();
            recursionFunction.calculate(baseNumber, exponent);
            Console.WriteLine($"{baseNumber} to the power of {exponent} is {recursionFunction.calculate(baseNumber, exponent)}");

            //Interface
            Car car = new Car(0);
            car.Drive();
            //fueladded
            Console.WriteLine("Enter amount for Refuel");
            int amt = int.Parse(Console.ReadLine());
            car.Refuel(amt);
            car.Drive();

     Console.ReadKey();
        }


    }
}

