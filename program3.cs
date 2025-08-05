using System;

namespace NewConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the first side:");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the second side:");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the third side:");
            double side3 = Convert.ToDouble(Console.ReadLine());

            
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                Console.WriteLine("Sides must be positive numbers.");
            }
            else if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }
    }
}