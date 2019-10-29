using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class TestCircle
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(1, "black");
            Console.WriteLine("The circle has radius of : {0} and area of : {1}", c1.GetRadius(), c1.GetArea());
            Circle c2 = new Circle(2.0, "Black");
            Console.WriteLine("The circle has radius of : {0} and area of : {1}", c2.GetRadius(), c2.GetArea());

            Circle c3 = new Circle(3, "orenge");
            Console.WriteLine("The circle has radius of : {0} and color of {1} ", c3.GetRadius(), c3.GetColor());

          //  c3.radius = 5;
            Circle c4 = new Circle();  
            c4.setRadius(5.0);       
            Console.Write("radius is: " + c4.GetRadius()); 
            c4.setColor("While");       
            Console.WriteLine("  color is: " + c4.GetColor());

            c4._Color = "red";
            Console.WriteLine(c4._Color);

            Circle c5 = new Circle();
            Console.WriteLine(c5.ToString());

        }
    }
}
