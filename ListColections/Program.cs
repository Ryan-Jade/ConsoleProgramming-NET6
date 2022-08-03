// See https://aka.ms/new-console-template for more information

//Declare a List
List<string> names = new List<string>();
string name = string.Empty;
//Add values on the list
names.Add(string.Empty);

Console.WriteLine("Enter Names:");

while (name != "-1")
{
    Console.Write("Enter Name:");
    name = Console.ReadLine();
    if (!string.IsNullOrEmpty(name) && name != "-1")
    {
        names.Add(name);
    } 
}

//Print the List

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("Printing names via for each loop");
foreach (string item in names)
{
    Console.WriteLine(item);
}