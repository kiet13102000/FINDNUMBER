using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3Circle
{
    class Circle
    {
        private float length;
        private float width;

        public void RecTangLe()
        {
            this.length=3;
            this.width = 4;
        }
        public void RecTangLe(float length, float width)
        {
            this.length = length;
            this.width = width;
        }
        public float getlength()
        {
            return length;
        }
        public void setlength(float length)
        {
            this.length = length;
        }
        public float getwidth()
        {
            return width;
        }
        public void setwidth(float width)
        {
            this.width = width;
        }
        public double getArea()
        {
            return length * width;
        }
        public double getPerimeter()
        {
            return (length + width) * 2;
        }
        public override string ToString()
        {
            return "RecTangLe[length] =" + length + ",with= {1}" + width;
        }
    }
}
