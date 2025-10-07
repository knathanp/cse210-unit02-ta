# Unit 02 - Team Activity

## Activity Instructions

For today's activity, please follow these instructions:

1.  Organize into small groups of 2-3 people. Circle around one laptop and designate one person to be the main typer for today.
    
2.  Begin by cloning this project template by clicking the `Use this template` button.

3. Clone the newly created repository to your laptop.
    
3.  Open and run the project in VS Code. You should be able to see the text "Welcome to the program." displayed in the terminal.
    
4.  Open the empty file `Address.cs`. This class will be used to represent a street address. In this file, create this new data type for a street address by creating the following member variables:
    
    * street  
    * city
    * state
    * zip code
        
5.  Create a member function `DisplayMailingLabel()` that displays an address with the street on the first line, and the city, state, and zip code on the second with a comma separating the city and state, like this:

    ```text
    525 S. Center St.
    Rexburg, ID 83460
    ```
    
6.  In your `Program.cs` file, create a new `Address` object, set the member variables to something of your choosing, and call the member function to display the address.
    
7.  Add a constructor to the `Address` class to set the member variables to reasonable default values. 

    Note: Constructors are special methods that are called automatically when an object is created. Their purpose is to help set up the initial state of an object. The name of a constructor must match the class name, and the return type is left empty (not even void).

    For example:

    ```c#
    public Address()
    {
        _street = "123 Anystreet St";
        _city   = "Anytown";
        _state  = "Idaho";
        _zip    = 88888;
    }   
    
8.  In your `Program.cs` file, create a second `Address` object and call the display member function for it, to see your default values rendered.
    
9.  In the empty `PhoneNumber.cs` file create a new class for a phone number that has the following member variables:
    
    * Area Code       
    * Prefix        
    * Suffix
        
10.  Create a member function `DisplayNumber` that outputs the phone number in the format: `(xxx) xxx-xxxx`, where the xxx's represent the area code, prefix, and suffix.
    
11.  In your `Program.cs` file, create a phone number, and display it.
    
12.  Change your `Address` class so that it also has a phone number as a member variable. Update the Address's Display function to call the phone number's display function after the other parts of the address are displayed. Then, update your `Program.cs` file to add a phone number to the addresses you declared previously.


## Sample Solution

See a sample solution in the `sample-solution` branch of this repository