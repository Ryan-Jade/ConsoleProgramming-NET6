// See https://aka.ms/new-console-template for more information

Person person = new Person();

string middleName = string.Empty;

Console.WriteLine("Enter First Name: ");
person.FirstName = Console.ReadLine();

Console.WriteLine("Enter Middle Name:");
middleName = Console.ReadLine();

Console.WriteLine("Enter Last Name: ");
person.LastName = Console.ReadLine();

Console.WriteLine("Enter your Age: ");
person.Age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Salary: ");
int sahod = Convert.ToInt32(Console.ReadLine());


person.setSalary(sahod);
Console.WriteLine($"First Name is {person.FirstName}");
Console.WriteLine($"Last Name is {person.LastName}");
Console.WriteLine($"Your Fullname is {person.getFullName()}");
Console.WriteLine($"Age is {person.Age}");
Console.WriteLine($"Salary is {person.getSalary()}");

if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine($"Full Name is {person.getFullName()}");
}
else
{
    Console.WriteLine($"Full Name is {person.getFullName(middleName)}");
}

// Assignment - Calculate the year of birth base on the age provided

string dateNow = DateTime.Now.ToString("dd-MM-yyyy");
string[] yearToday = dateNow.Split('-');

//Console.WriteLine(yearToday[2]);
//Console.WriteLine(dateNow);
 int birthYear = Convert.ToInt32((Convert.ToInt32(yearToday[2]) - person.Age));

Console.WriteLine($"Your Birth Year is :{Convert.ToInt32(birthYear)}");