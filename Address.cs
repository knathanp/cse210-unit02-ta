using System;

namespace Cse210_Unit02_Ta
{
    public class Address
    {
        // Member variables (i.e., attributes)
        public string street = "";
        public string city = "";
        public string state = "";
        public PhoneNumber phone = new PhoneNumber();

        // Constructor
        public Address()
        {
            street = "123 Any Street";
            city = "Nowhere";
            state = "Idaho";
            phone.AreaCode = "208";
            phone.Prefix = "867";
            phone.Suffix = "5309";
        }

        // Display a mailing label
        public void DisplayMailingLabel()
        {
            Console.WriteLine(street);
            Console.WriteLine($"{city}, {state}");
            phone.DisplayNumber(); // use the DisplayNumber() method in the PhoneNumber class
            Console.WriteLine();
        }

    }
}
