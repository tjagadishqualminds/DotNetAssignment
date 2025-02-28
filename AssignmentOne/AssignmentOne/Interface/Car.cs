using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne.Interface
{
    public class Car : IVehiculo
    {
        int gasoline;
        public Car(int gasoLine) { 
            gasoline = gasoLine;
        }
       public  void Drive()
        {
          if(gasoline > 0)
            {
                Console.WriteLine("car is driving ");
            }
          else
            {
                Console.WriteLine("refuel the car");
            }
        }

       public bool Refuel(int amount)
        {
            gasoline += amount;
            return true;
        }
    }
}
