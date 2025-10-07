using System;


public class PhoneNumber
{
    // Member variables
    public string _areaCode = "";
    public string _prefix = "";
    public string _suffix = "";

    public PhoneNumber()
    {
        // empty constructor
    }

    public void DisplayNumber()
    {
        Console.WriteLine($"({_areaCode}) {_prefix}-{_suffix}");
    }

}
