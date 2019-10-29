using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3Circle
{
    class RecTangLe
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            c1.RecTangLe(4, 3);
            Console.WriteLine("The circle has Perimeter of : {0} and area of : {1}", c1.getPerimeter(), c1.getArea() );
            Console.WriteLine(c1.ToString());
        }
    }
}
