using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        private double radius;
        private string color;
        public Circle()
        {
            radius = 1;
            color = "red";
        }
        public Circle(double r)
        {
            radius = r;
            color = "red";
        }
        public double GetRadius()
        {
            return radius;
        }
        public double GetArea()
        {
            return radius * radius * Math.PI;
        }
        public Circle (double r, String c)
        {
             radius= r;
             color = c;
        }
        public string GetColor()
        {
            return this.color;
        }
        public void setRadius(double newRadius)
        {
            radius = newRadius;
        }
        public void setColor(String newColor)
        {
            color = newColor;
        }
        public String _Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }
        //overload
        public override string ToString()
        {
            return "abc";
        }
    }
}
