using System;
class TicketAttendant
{
    //public static float ticketPrice = 10;
    static float discountApplyer(int age)
    {
        float price = 10;
        if (age >= 65 || age <= 12)
        {
            Console.WriteLine("Hurray, you are eligible for this discount!");
            price = 7;
        }
        else { Console.WriteLine("Sorry,you are not eligible for this discount."); }
        return price;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello,customer! You may be eligible for a discount,how old are you?");
        string input = Console.ReadLine();

        int x;
        if (int.TryParse(input, out x))
        {
            TicketAttendant paulAmmah = new TicketAttendant();
            Console.WriteLine("Final Price: " + discountApplyer(x));
        }
        else
        {
            Console.WriteLine("That's not a valid age.");
        }
    }
}