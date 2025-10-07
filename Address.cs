using System;


public class Address
{
    // Member variables (i.e., attributes)
    public string _street = "";
    public string _city = "";
    public string _state = "";
    public string _zip = "";
    public PhoneNumber _phone = new PhoneNumber();

    // Constructor
    public Address()
    {
        _street = "123 Anystreet";
        _city = "Nowhere";
        _state = "Idaho";
        _phone._areaCode = "208";
        _phone._prefix = "867";
        _phone._suffix = "5309";
    }

    // Display a mailing label
    public void DisplayMailingLabel()
    {
        Console.WriteLine(_street);
        Console.WriteLine($"{_city}, {_state} {_zip}");
        _phone.DisplayNumber(); // use the DisplayNumber() method in the PhoneNumber class
        Console.WriteLine();
    }

}

