Unit 02 - Team Activity
=======================

Overview
--------

Practice Class Fundamentals in C#

Background
----------

You may refer back to the following:

*   [Abstraction - The first principle](https://byui-cse.github.io/cse210-course-competency/abstraction/materials/the-first-principle.html)
    
*   [Classes in C#](https://video.byui.edu/media/t/1_ye5qy14x) (9 min video)
    
*   [Class Methods in C#](https://video.byui.edu/media/t/1_wbgk3tu1) (8 min video)
    

--------
### A side note:

Static Functions

After watching these videos you can now understand where the `static` keyword fits in.

As discussed, all member functions must run in the context of an object. This is the variable name that comes before the dot (for example, the `book1` variable in `book1.DisplayInfo()` ). This is almost always what we want, when we are programming with classes.

If you want a function that does not run in the context of an object, you can use the `static` keyword. This says that the function can run on its own, without any context.

Previously, when you were writing functions like `Main` or other non-object-oriented functions in your first few programs, you did not want them to run in the context of an object, because you had not created any yet. For this reason, those functions were static. You will still want `Main` to be a static function, but outside of Main, nearly all of your functions now will be member functions that you want the context of an object for, so you will not be using static very much anymore.

--------------


Activity Instructions
---------------------

For today's activity, please follow these instructions:

1.  Organize into small groups of 2-3 people. Circle around one laptop and designate one person to be the main typer for today.
    
2.  Clone the following project template to begin: [https://github.com/knathanp/cse210-unit02-ta](https://github.com/knathanp/cse210-unit02-ta)
    
3.  Open and run the project in VS Code. You should be able to see the text "Welcome to the program." displayed in the terminal.
    
4.  Open the empty file `Address.cs`. In this file, create a new data type for a street address with the following member variables:
    
    * street  
    * city
    * state
        
5.  Create a member function `DisplayMailingLabel()` that displays an address with the street on the first line, and the city and state on the second with a comma separating them.
    
6.  In your `Program.cs` file, create a new `Address` object, set the member variables to something of your choosing, and call the member function to display the address.
    
7.  Add a constructor to the `Address` class to set the member variables to reasonable default values.
    
8.  In your `Program.cs` file, create a second `Address` object and call the display member function for it, to see your default values rendered.
    
9.  In the empty `PhoneNumber.cs` file create a new class for a phone number that has the following member variables:
    
    * Area Code       
    * Prefix        
    * Suffix
        
10.  Create a member function `DisplayNumber` that outputs the phone number in the format: `(xxx) xxx-xxxx`, where the xxx's represent the area code, prefix, and suffix.
    
11.  In your `Program.cs` file, create a phone number, and display it.
    
12.  Change your `Address` class so that it also has a phone number as a member variable. Update the Address's Display function to call the phone number's display function after the other parts of the address are displayed. Then, update your `Program.cs` file to add a phone number to the addresses you declared previously.