using System;

namespace Cse210_Unit02_Ta
{
    public class PhoneNumber
    {
        // Member variables
        // Could use int or string here
        public string AreaCode = "";
        public string Prefix = "";
        public string Suffix = "";

        public PhoneNumber()
        {
            // empty constuctor
        }

        public void DisplayNumber()
        {
            Console.WriteLine($"({AreaCode}) {Prefix}-{Suffix}");
        }

    }
}
