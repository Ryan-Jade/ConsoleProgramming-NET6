// See https://aka.ms/new-console-template for more information

string firstName = "Ryan";
string lastName = "Escobar";

Console.WriteLine($"My name is {firstName} {lastName}.");

string newName = firstName.Replace("R", "Ry");

Console.WriteLine($"My new first name is {newName}.");

string convertToString = null;

convertToString = 12323.ToString();
Console.WriteLine(convertToString);