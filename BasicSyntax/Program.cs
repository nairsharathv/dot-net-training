// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// single line command

/* 
 multiline comment
 */

/*
statements should be ended with ";"


if (true) {
    do something;
}

indentation is used just for code readability
*/


// Data Types: string, int, float, double, char, boolean
// Type Conversion

string fullName = string.Empty;
int age = 0;
double salary = 0.0;
char gender = char.MinValue;
bool working = false;

Console.Write("Please enter your name: ");
fullName = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary: ");
salary = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your gender (M/F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Please enter your working: ");
working = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("The name entered is " + fullName);
Console.WriteLine("The age entered is " + age);
Console.WriteLine("The salary entered is " + salary);
Console.WriteLine("The gender entered is " + gender);
Console.WriteLine("Is working ? " + working);
