// See https://aka.ms/new-console-template for more information

// Declare Fixed Size Array
int[] grades = new int[5];
// 5 space addresses

// Add values to Fixed Size Array
//grades[0] = 1;
//grades[1] = 2;
//grades[2] = 3;
//grades[3] = 4;
//grades[4] = 5;

//grades = new int[] (1,2,3,4,5);
Console.WriteLine("Enter All Grades");
for (int i = 0; i < grades.Length; i++)
{
    Console.Write( "Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("The Grades you have entered are:");

for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(grades[i]);
}

//Declare Variable Sized Array

string[] studentNames = new string[] {"try", "try", "test"};

Console.WriteLine("Enter name");
for (int i = 0; i < studentNames.Length; i++)
{
    Console.Write($"Name:");
    studentNames[i] = Console.ReadLine();
}
Console.WriteLine("The Nmae are: ");
for (int i = 0; i <= studentNames.Length; i++)
{
    Console.WriteLine(studentNames[i]);
}
