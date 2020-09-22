using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Hinh
{
    public class Circle : Shape
    {
        public double radius;
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
        public override double Perimeter()
        {
            return Math.PI * 2 * radius;
        }
        public Circle (double radius)
        {
            this.radius = radius;
        }
        public double getRadius(double radius)
        {
            return radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
    }
}
