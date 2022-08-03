// See https://aka.ms/new-console-template for more information

// Variable Declaration and Types

string fullName = string.Empty;
int age = 0;
double salary = 0.0;
char gender = char.MinValue;
bool working = false;

// User input
Console.Write("Please enter your Full Name: ");
fullName = Console.ReadLine();

Console.Write("Please enter your Age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your Salary: ");
salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Please enter your Gender: ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you currently working? (True or False): ");
working = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("");
Console.WriteLine("");

// Console Output
Console.WriteLine("Your Name is " +fullName);
Console.WriteLine("Your Age is " + age);
Console.WriteLine("Your Salary is " + salary + " Pesos Monthly");
Console.WriteLine("Your Gender is " + gender);

if (working == true)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No :(");
}

