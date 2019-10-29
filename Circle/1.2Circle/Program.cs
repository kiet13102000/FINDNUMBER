using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Console.WriteLine("The circle has radius of : {0} and area of : {1}",  c1.getRadius(), c1.getArea() );
            Console.WriteLine(c1.ToString());
        }
    }
}
