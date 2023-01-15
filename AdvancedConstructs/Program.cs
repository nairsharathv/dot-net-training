
using System.Globalization;
 
// Topic 1: Methods
// returnType MethodName(paramType paramName, ...) {} // Pascal case for function and Camelcase for var

// With no return types
Console.Write("Enter number 1 : ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2 : ");
int num2 = Convert.ToInt32(Console.ReadLine());

void Add(int num1, int num2)
{
    Console.WriteLine($"Addition : {num1 + num2}");
}

Add(num1, num2);
Add(1, 4); // 5

// With return type
int GreaterThan(int a , int b, int c)
{
    int largest = a;
    if (b > largest) largest = b;
    if (c > largest) largest = c;
    return largest;
}

int largest = GreaterThan(10, 15, 8);
Console.WriteLine($"Largest number is : {largest}");





// Topic 2: String manipulation

// Concatenation
string firstName = "Sharath";
string lastName = "Nair";

string fullName = firstName +  " " + lastName;

// Length of a string
int length = firstName.Length;
Console.WriteLine($"First name has {length} letters");

// Replace string parts
string newFirstName = firstName.Replace("Sha", "Bha");
Console.WriteLine($"New first name is {newFirstName}");

// Split
string toSplit = "Jerrish, Mithun, Jerald, Jijo, Tomson";
string[] names = toSplit.Split(", ");
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

// Compare
string nullString = null;
string emptyString = "";
string whiteSpaceString = " ";

if (string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("nullString is empty or null");
}
if (string.IsNullOrWhiteSpace(nullString))
{
    Console.WriteLine("nullString is empty or has whitespaces");
}
if (firstName.CompareTo(lastName) == 0)
{
    Console.WriteLine("firstName and lastName are equal");
}
if (string.Equals(firstName, lastName))
{
    Console.WriteLine("firstName and lastName are equal");
}
if (firstName.Equals(lastName))
{
    Console.WriteLine("firstName and lastName are equal");
}



// Topic 3: DateTime related functionality

// Empty DateTime
DateTime date = new DateTime();

// Create DateTime from date
DateTime dateOfBirth = new DateTime(1980, 1, 25);
Console.WriteLine($"Date of birth is {dateOfBirth}");

// Create DateTime from string
DateTime parsedDate = DateTime.Parse("3/31/2000", CultureInfo.InvariantCulture);
Console.WriteLine($"Parsed date is {parsedDate}");


// Create DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine($"Current time is {now}");

// Date to ticks
Console.WriteLine($"Ticks for now is {now.Ticks}");

// Add hours to DateTime
Console.WriteLine($"2 hours from now is {now.AddHours(2)}");

// DateOnly
DateOnly dob = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine(dob);

// TimeOnly
TimeOnly tob = TimeOnly.FromDateTime(dateOfBirth);
Console.WriteLine(tob);



// Topic 4: Exception Handling

Console.Write("Enter number 1 : ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2 : ");
int num4 = Convert.ToInt32(Console.ReadLine());

try
{
    double quotient = num3 / num4;
    Console.WriteLine($"Result is {quotient}");
}
catch (DivideByZeroException e)
{
    Console.WriteLine($"Illegal operation performed: {e.Message}");
}
catch (Exception ex)
{
	throw ex;
}
finally
{
    Console.WriteLine("Exited the program");
}



// Topic 5: Arrays
// initialize a fixed sized array
int[] marks = new int[5]; // 0 based index (0-4)

// iterate an array
for (int i = 0; i < marks.Length; i++)
{
    Console.Write("Enter marks: ");
    marks[i] = Convert.ToInt32(Console.ReadLine());
}

// print an array of elements
for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine(marks[i]);
}

string[] nameList = new string[] { "Jerrish", "Jerald", "Mithun" };


// Topic 6: Lists
List<string> devs = new List<string>();
string dev = string.Empty;

while (!dev.Equals("-1"))
{
    Console.Write("Enter the name of developer: ");
    dev = Console.ReadLine();
    if (dev != string.Empty && !dev.Equals("-1"))
    {
        devs.Add(dev);
    }
}

foreach (string name in devs)
{
    Console.WriteLine(name);
}


// Topic 7: API documentation
// Refer this link: https://learn.microsoft.com/en-us/dotnet/api/?view=net-6.0&term=string


/* PS:
 * DRY - Don't Repeat Yourself
 * Arrays are of fixed length/memory.
 * Arrays are more memory efficient than lists.
 * Lists are of variable length.
 * using list.Add() is more preferabble than push data using their indices.
 * epoch: a date and time from which a computer measures system time.
 * It measures time by the number of seconds that have elapsed since 00:00:00 UTC on 1 January 1970, the beginning of the Unix epoch
 */
