using System;

class TriangleID
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the first side:");
        double side1 = GetPositiveDouble();

        Console.WriteLine("Enter the length of the second side:");
        double side2 = GetPositiveDouble();

        Console.WriteLine("Enter the length of the third side:");
        double side3 = GetPositiveDouble();

        // Determine the type of triangle
        if (side1 == side2 && side2 == side3)
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

    static double GetPositiveDouble()
    {
        double number;
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out number) && number > 0)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number:");
            }
        }
    }
}
