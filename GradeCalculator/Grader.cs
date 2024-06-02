using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
public class Grader
{

    internal char Grade { get; set;}
    public Grader(decimal grade=0) {
        if (grade >= 90) { Grade = 'A'; }
        else if (grade >= 80) { Grade = 'B'; }
        else if (grade >=70) { Grade = 'C';}
        else if(grade >= 60) { Grade = 'D';}
        else { Grade = 'F';}
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a grade between 1-100.");
        string input = Console.ReadLine();

        decimal x;
        if (decimal.TryParse(input, out x))
        {
            Grader paulAmmah = new Grader(x);
            Console.WriteLine("Grade Computed: " + paulAmmah.Grade);
        }
        else
        {
            Console.WriteLine("That's not a valid number.");
        }

       

    }
}