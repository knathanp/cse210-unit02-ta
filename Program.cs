using System;

namespace Cse210_Unit02_Ta
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the program.");

            // Create an Address object, (i.e., an instance of an Address)
            Address a1 = new Address();
            a1.street = "15 S Center St";
            a1.city = "Rexburg";
            a1.state = "Idaho";

            // Add a phone number ("phone" is a member variable in Address class)
            a1.phone.AreaCode = "555";
            a1.phone.Prefix = "356";
            a1.phone.Suffix = "9999";
            a1.DisplayMailingLabel();

            Address a2 = new Address();
            a2.DisplayMailingLabel(); // should display default values

            PhoneNumber p1 = new PhoneNumber();
            p1.AreaCode = "208";
            p1.Prefix = "123";
            p1.Suffix = "4567";
            p1.DisplayNumber();

            Console.WriteLine();
            a2.phone = p1; // we can assign a previously created PhoneNumber to this Address's member variable
            a2.DisplayMailingLabel();

        }
    }
}
