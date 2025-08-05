using System;

namespace NewConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numerical grade between 0 and 100:");
            string input = Console.ReadLine();

            
            if (int.TryParse(input, out int grade))
            {
                if (grade >= 0 && grade <= 100)
                {
                    
                    char letterGrade;

                    if (grade >= 90)
                    {
                        letterGrade = 'A';
                    }
                    else if (grade >= 80)
                    {
                        letterGrade = 'B';
                    }
                    else if (grade >= 70)
                    {
                        letterGrade = 'C';
                    }
                    else if (grade >= 60)
                    {
                        letterGrade = 'D';
                    }
                    else
                    {
                        letterGrade = 'F';
                    }

                    Console.WriteLine($"Your letter grade is: {letterGrade}");
                }
                else
                {
                    Console.WriteLine("Please enter a grade between 0 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numerical grade.");
            }
        }
    }
}