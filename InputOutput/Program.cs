// See https://aka.ms/new-console-template for more information


// Declaring a Variable.
/*  Data Types
    string - words/numbers (use double qoutation mark)
    int - whole number
    char - one character only (use single quotation mark)  
 */

string fullName;

//Allow user input and store in variable
Console.WriteLine("Enter Your Full Name: ");
fullName = Console.ReadLine();

//Print contents of variable/user's input
Console.WriteLine("My name is " + fullName);