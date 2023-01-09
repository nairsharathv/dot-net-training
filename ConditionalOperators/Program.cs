// Conditionals
// if else ( ==, >, <, >=, != )
Console.WriteLine("CONDITIONAL STATEMENTS");
Console.Write("Enter number of apples: ");
int numberOfApples = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of oranges: ");
int numberOfOranges = Convert.ToInt32(Console.ReadLine());

if (numberOfApples > numberOfOranges)
{
    Console.WriteLine("There are more apples than oranges");
}
else if (numberOfOranges > numberOfApples)
{
    Console.WriteLine("There are more oranges than apples");
}
else if (numberOfOranges == numberOfApples)
{
    Console.WriteLine("Apples and oranges are equal");
}
else
{
    Console.WriteLine("Invalid");
}


// switch
Console.WriteLine();
Console.WriteLine("SWITCH STATEMENTS");
Console.WriteLine("Enter your marks (0-100): ");
int marks = Convert.ToInt32(Console.ReadLine());

switch(marks)
{
    case int n when (n < 50):
        Console.WriteLine("You are failed");
        break;
    case int n when (n >= 50 && n <= 100):
        Console.WriteLine("You are passed");
        break;
    default: Console.WriteLine("Invalid input for mark");
        break;

}


// ternary - <condition> ? true action : false action

Console.WriteLine();
Console.WriteLine("TERNARY OPERATORS");
var resullt = numberOfApples < numberOfOranges ? "There are more apples than oranges" : "There are more apples than oranges";
Console.WriteLine(resullt);