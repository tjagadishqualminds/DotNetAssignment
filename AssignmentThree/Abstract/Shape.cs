using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree.Abstract
{
  public  class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Drawing a circle");
        }
    }



}
