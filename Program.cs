using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab10
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            string restart;
            List<Circle> circles = new List<Circle>();

            do
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Enter radius: ");
                        radius = double.Parse(Console.ReadLine());
                        if (radius > 0)

                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You must enter positive number");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("This is not a number");
                    }
                }
                while (true);


                Circle circleFinder = new Circle(radius);
                circles.Add(circleFinder);
                Console.WriteLine("The area of your number is: " + circleFinder.CalculateFormattedArea());

                Console.WriteLine("The circumference of your number is: " + circleFinder.CalculateFormattedCircumference());

                Console.WriteLine("Do you wish to continue? (Y or N");
                restart = Console.ReadLine();


                if (restart.ToLower() == "n")
                {
                    Console.WriteLine("Goodbye! You built " + circles.Count + " cirlce(s)");
                    
                }

                

            } while (restart.ToLower() == "y");
           
            Console.ReadLine();
}
    }
}
