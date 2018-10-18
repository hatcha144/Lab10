using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab10
{
    class Circle
    {
        private double radius;
        

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double CalculateCircumference()
        {
            double pi = Math.PI;
            double circumference = 2 * pi * radius;
            return circumference;
        }
        public string CalculateFormattedCircumference()
        {
            double circumference = CalculateCircumference();
           
            return FormatNumber(circumference);
        }
        public double CalculateArea()
        {
            double area = Math.PI * radius * radius;
            return area;
        }
        public string CalculateFormattedArea()
        {
            double area = CalculateArea();
            
            return FormatNumber(area);
        }
        private string FormatNumber(double x)
        {
            double cirumference = x;
            return String.Format("{0:0.##}", x);
            
        }
           
        
    }
}
