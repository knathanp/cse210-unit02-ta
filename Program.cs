using System;


public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the program.");

        // Create an Address object, (i.e., an instance of an Address)
        Address a1 = new Address();
        a1._street = "15 S Center St";
        a1._city = "Rexburg";
        a1._state = "Idaho";

        // Add a phone number ("phone" is a member variable in Address class)
        a1._phone._areaCode = "555";
        a1._phone._prefix = "356";
        a1._phone._suffix = "9999";
        a1.DisplayMailingLabel();

        Address a2 = new Address();
        a2.DisplayMailingLabel(); // should display default values

        PhoneNumber p1 = new PhoneNumber();
        p1._areaCode = "208";
        p1._prefix = "123";
        p1._suffix = "4567";
        p1.DisplayNumber();

        Console.WriteLine();
        a2._phone = p1; // we can assign a previously created PhoneNumber to this Address's member variable
        a2.DisplayMailingLabel();

    }
}

