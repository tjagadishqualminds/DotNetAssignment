using ArrayAndInterface.Array;
using ArrayAndInterface.Interface;
using ArrayAndInterface.Loops;
using ArrayAndInterface.Recursion;

namespace ArrayAndInterface
{
    public class Program
    {

        static void Main()
        {
          //compressedstring
            Compressed compressed = new Compressed();
            compressed.CompressedString("jjaaggaaddiisshh");


            CommonElement commonelement = new CommonElement();
            commonelement.CommonElementOperationOne();

            //commonelement
            CommonElementTwo commonelementtwo = new CommonElementTwo();
            commonelementtwo.CommonElementOperationTwo();

            //reverse number
            Reverse number = new Reverse();
           int rs= number.ReversedNumber(122);
            Console.WriteLine( "reversenumber"+rs);


            //Recursion
            int baseNumber = 5;
            int exponent = 3;
            RecursionFunction recursionFunction = new RecursionFunction();
            recursionFunction.Calculate(baseNumber, exponent);
            Console.WriteLine($"{baseNumber} to the power of {exponent} is {recursionFunction.Calculate(baseNumber, exponent)}");

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

