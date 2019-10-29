using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2Circle
{
    class Circle
    {
        private double radius = 1;
        public void circle()
        {
            this.radius = 1;
        }
        public void circle( double radius)
        {
            this.radius = radius;
        }
        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public  double getArea()
        {
            return radius * radius * Math.PI;
        }
        public double getCircumference(double radius)
        {
            return radius * 2 * Math.PI;
        }
        public override string ToString()
        {
            return "Circle[radius={0}]";

        }
    }
   
}
